using MVC_QLKHO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_QLKHO.Controllers
{
    public class HangHoaController : BaseController
    {
        //
        // GET: /HangHoa/
        public ActionResult Index()
        {
            return View(new Models.dbQLKhoEntities().HangHoas.ToList().Where(q => q.IsDelete != true).ToList());
        }

        public ActionResult Edit(string id = null)
        {
            HangHoa ob = new HangHoa()
            {
                IsDelete = null
            };

            ViewBag.Title = "THÊM MỚI HÀNG HÓA";
            if (string.IsNullOrEmpty(id) == false)
            {
                ob = new dbQLKhoEntities().HangHoas.ToList().FirstOrDefault(q => q.MaHH == id);
                if (ob == null) RedirectToAction("Index");
                ViewBag.Title = "SỬA HÀNG HÓA";
                ViewBag.selectNHH = new SelectList(new dbQLKhoEntities().NhomHangHoas.ToList().Where(q => q.IsDelete != true).OrderBy(q => q.TenNHH).ToList(), "ID_NHH", "ID_NHH", ob.ID_NHH);
            }
            else
            {
                ViewBag.selectNHH = new SelectList(new dbQLKhoEntities().NhomHangHoas.ToList().Where(q => q.IsDelete != true).OrderBy(q => q.TenNHH).ToList(), "ID_NHH", "TenNHH");
            }
            return View(ob);
        }

        [HttpPost]
        public ActionResult Edit(HangHoa ob)
        {
            var db = new dbQLKhoEntities();
            var t_ob = db.HangHoas.ToList().FirstOrDefault(q => q.MaHH == ob.MaHH);
            if (t_ob == null)
            {
                ob.IsDelete = false;
                ob.SoLuongTon = 0;
                db.HangHoas.Add(ob);
                db.SaveChanges();
            }
            else if (t_ob.IsDelete == true)
            {
                ModelState.AddModelError("", "MÃ HÀNG HÓA ĐÃ BỊ XÓA VÀ KHÔNG THỂ PHỤC HỒI");
                ob.MaHH = "";
                ViewBag.selectNHH = new SelectList(new dbQLKhoEntities().NhomHangHoas.ToList().Where(q => q.IsDelete != true).OrderBy(q => q.TenNHH).ToList(), "ID_NHH", "ID_NHH", ob.ID_NHH);
                return View(ob);
            }
            else
            {
                var context = new dbQLKhoEntities();
                ob.IsDelete = false;
                context.Entry(ob).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public JsonResult Delete(string id)
        {
            var db = new dbQLKhoEntities();
            bool r_delete = false;
            var ob = db.HangHoas.ToList().FirstOrDefault(q => q.MaHH == id);
            if (ob != null)
            {
                ob.IsDelete = true;
                r_delete = db.SaveChanges() > 0;
            }
            return Json(r_delete);
        }
	}
}