using MVC_QLKHO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_QLKHO.Controllers
{
    public class NhomHangHoaController : BaseController
    {
        public ActionResult Index()
        {
            return View(new Models.dbQLKhoEntities().NhomHangHoas.ToList().Where(q => q.IsDelete != true).ToList());
        }

        public ActionResult Edit(string id = null)
        {
            NhomHangHoa ob = new NhomHangHoa()
            {
                IsDelete = false
            };
            ViewBag.Title = "THÊM MỚI NHÓM HÀNG HÓA";
            if (string.IsNullOrEmpty(id) == false)
            {
                ob = new dbQLKhoEntities().NhomHangHoas.ToList().FirstOrDefault(q => q.ID_NHH == id);
                if (ob == null) RedirectToAction("Index");
                ViewBag.Title = "SỬA NHÓM HÀNG HÓA";
            }
            return View(ob);
        }

        [HttpPost]
        public ActionResult Edit(NhomHangHoa ob)
        {
            var db = new dbQLKhoEntities();
            var t_ob = db.NhomHangHoas.ToList().FirstOrDefault(q => q.ID_NHH == ob.ID_NHH);
            if (t_ob == null)
            {
                ob.IsDelete = false;
                db.NhomHangHoas.Add(ob);
                db.SaveChanges();
            }
            else if (t_ob.IsDelete == true)
            {
                ModelState.AddModelError("", "NHÓM HÀNG ĐÃ BỊ XÓA VÀ KHÔNG THỂ PHỤC HỒI");
                ob.ID_NHH = "";
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
            var ob = db.NhomHangHoas.ToList().FirstOrDefault(q => q.ID_NHH == id);
            if (ob != null)
            {
                ob.IsDelete = true;
                r_delete = db.SaveChanges() > 0;
            }
            return Json(r_delete);
        }
	}
}