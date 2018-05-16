using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_QLKHO.Models;

namespace MVC_QLKHO.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var db = new Models.dbQLKhoEntities();
            ViewBag.lstNhaKho = db.NhaKhoes.ToList();
            ViewBag.lstViTriSua = db.VitriSuas.ToList();
            ViewBag.selectNCC = new SelectList(db.NhaCungCaps.ToList().Where(q => q.IsDelete != true), "MaNCC", "TenNCC");
            ViewBag.selectHH = new SelectList(db.HangHoas.ToList().Where(q => q.IsDelete != true), "MaHH", "TenHH");
            return View(db.LoHangs.ToList().Where(q => q.Status != 0).ToList());
        }

        public JsonResult AddViTriSua(VitriSua ob)
        {
            var db = new dbQLKhoEntities();
            db.VitriSuas.Add(ob);
            return Json(db.SaveChanges() > 0);
        }

        public JsonResult Fixed(int id)
        {
            var db = new dbQLKhoEntities();
            var ob = db.VitriSuas.ToList().FirstOrDefault(q => q.ID_ViTri == id);
            if (ob == null) return Json(true);
            db.VitriSuas.Remove(ob);
            return Json(db.SaveChanges() > 0);
        }

        [HttpPost]
        public ActionResult XuatKho(List<CT_XuatKho> lst_XuatKho)
        {
            if (lst_XuatKho != null && lst_XuatKho.Count > 0)
            {
                var phieuXuat = new PhieuXuat
                {
                    ID_NhanVien = LoginHelper.GetAccount().MaNV,
                    Note = "",
                    ThoiGian = DateTime.Now
                };
                var db = new dbQLKhoEntities();
                db.PhieuXuats.Add(phieuXuat);

                var lstHang = db.LoHangs.ToList().Where(q => q.Status != 0).ToList();
                var lstHangHoa = db.HangHoas.ToList();
                foreach (var item in lst_XuatKho)
                {
                    var ob = lstHang.FirstOrDefault(q => q.MaLoHang == item.MaLoHang);
                    if (ob != null)
                    {
                        db.CT_XuatKho.Add(new CT_XuatKho
                        {
                            ID_PhieuXuat = phieuXuat.ID_PhieuXuat,
                            MaLoHang = item.MaLoHang,
                            Note = item.Note,
                            SoLuong = item.SoLuong
                        });

                        ob.SoLuong -= item.SoLuong;
                        if (ob.SoLuong <= 0)
                        {
                            ob.Status = 0;
                        }
                        var hh = lstHangHoa.FirstOrDefault(q => q.MaHH == ob.MaHH);
                        if (hh != null)
                        {
                            hh.SoLuongTon -= item.SoLuong;
                        }
                    }
                }
                if (db.SaveChanges() > 0)
                {
                    return RedirectToAction("Index", "CTXuatKho", new { ID_PhieuXuat = phieuXuat.ID_PhieuXuat });
                }
                else
                {
                    ModelState.AddModelError("", "Xuất kho thất bại, tải lại trang web và thử lại.");
                }
            }
            else
            {
                ModelState.AddModelError("", "Xuất kho thất bại, vui lòng chọn các lô hàng để xuất.");
            }
            return RedirectToAction("Index");
        }

        public ActionResult NhapKho(List<LoHang> lst_LoHang)
        {
            if (lst_LoHang.Count > 0)
            {
                var db = new dbQLKhoEntities();
                var hanghoa = db.HangHoas.ToList();
                var phieuNhap = new PhieuNhap
                {
                    ID_NhanVien = LoginHelper.GetAccount().MaNV,
                    Note = "",
                    ThoiGian = DateTime.Now
                };
                db.PhieuNhaps.Add(phieuNhap);

                var r = db.SaveChanges() > 0;
                if (r)
                {
                    foreach (var item in lst_LoHang)
                    {
                        var hh = hanghoa.FirstOrDefault(q => q.MaHH == item.MaHH);
                        hh.SoLuongTon += item.SoLuong;
                        db.LoHangs.Add(new LoHang
                        {
                            Cot = item.Cot,
                            Hang = item.Hang,
                            HSD = item.HSD,
                            ID_NhaKho = item.ID_NhaKho,
                            ID_PhieuNhap = phieuNhap.ID_PhieuNhap,
                            MaHH = item.MaHH,
                            MaNCC = item.MaNCC,
                            NSX = item.NSX,
                            SoLuong = item.SoLuong,
                            Status = 1,
                            Tang = item.Tang
                        });
                    }
                    if (db.SaveChanges() > 0)
                    {
                        return RedirectToAction("Index", "CTNhapKho", new { ID_PhieuNhap = phieuNhap.ID_PhieuNhap });
                    }
                    else
                    {
                        ModelState.AddModelError("", "Xuất kho thất bại, tải lại trang web và thử lại.");
                    }
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult Detail(int id)
        {
            var ob = new dbQLKhoEntities().LoHangs.ToList().FirstOrDefault(q => q.MaLoHang == id);
            return View(ob);
        }
    }
}