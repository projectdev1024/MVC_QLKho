using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_QLKHO.Models;
using ClosedXML.Excel;
using System.IO;

namespace MVC_QLKHO.Controllers
{
    public class CTNhapKhoController : BaseController
    {
        public ActionResult Index(int ID_PhieuNhap, string export_excel = null)
        {
            var phieuNhap = new dbQLKhoEntities().PhieuNhaps.ToList().FirstOrDefault(q => q.ID_PhieuNhap == ID_PhieuNhap);
            ViewBag.phieuNhap = phieuNhap;
            var data = new dbQLKhoEntities().LoHangs.ToList().Where(q => q.ID_PhieuNhap == ID_PhieuNhap && q.Status != 0).ToList();
            if (string.IsNullOrWhiteSpace(export_excel) == false && data != null && data.Count > 0)
            {
                XLWorkbook wb = new XLWorkbook(Server.MapPath(@"\Content\Export\nhapkho.xlsx"));
                var ws = wb.Worksheet(1);
                var index_row = 5;

                ws.Row(index_row++).Cell(5).Value = phieuNhap.ID_PhieuNhap;
                ws.Row(index_row++).Cell(5).Value = phieuNhap.ThoiGian;
                ws.Row(index_row++).Cell(5).Value = string.Format("{0} - {1}", phieuNhap.NhanVien.MaNV, phieuNhap.NhanVien.TenNV);

                index_row = 10;
                for (int i = 0; i < data.Count; i++)
                {
                    var item = data[i];
                    var index_col = 1;
                    ws.Row(index_row).Cell(index_col++).Value = i + 1;
                    ws.Row(index_row).Cell(index_col++).Value = item.MaLoHang;
                    ws.Row(index_row).Cell(index_col++).Value = item.MaHH;
                    ws.Row(index_row).Cell(index_col++).Value = item.NSX;
                    ws.Row(index_row).Cell(index_col++).Value = item.HSD;
                    ws.Row(index_row).Cell(index_col++).Value = item.SoLuong;
                    ws.Row(index_row).Cell(index_col++).Value = item.ID_NhaKho;
                    ws.Row(index_row).Cell(index_col++).Value = item.MaNCC;
                    ws.Row(index_row).Cell(index_col++).Value = string.Format("Tầng {0} - Hàng {1} - Cột {2}", item.Tang, item.Hang, item.Cot);
                }

                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                }
            }
            return View(data);
        }
    }
}