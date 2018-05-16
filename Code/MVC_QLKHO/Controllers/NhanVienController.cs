using MVC_QLKHO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_QLKHO.Controllers
{
    public class NhanVienController : BaseController
    {
        public ActionResult Index()
        {
            return View(new Models.dbQLKhoEntities().NhanViens.ToList().Where(q => q.IsDelete != true).ToList());
        }

        public ActionResult Edit(string id = null)
        {
            NhanVien ob = new NhanVien()
            {
                IsDelete = false
            };
            ViewBag.Title = "THÊM MỚI NHÂN VIÊN";
            if (string.IsNullOrEmpty(id) == false)
            {
                ob = new dbQLKhoEntities().NhanViens.ToList().FirstOrDefault(q => q.MaNV == id);
                if (ob == null) RedirectToAction("Index");
                ViewBag.Title = "SỬA NHÂN VIÊN";
            }
            return View(ob);
        }

        [HttpPost]
        public ActionResult Edit(NhanVien ob)
        {
            var db = new dbQLKhoEntities();
            var t_ob = db.NhanViens.ToList().FirstOrDefault(q => q.MaNV == ob.MaNV);
            if (t_ob == null)
            {
                ob.IsDelete = false;
                db.NhanViens.Add(ob);
                db.SaveChanges();
            }
            else if (t_ob.IsDelete == true)
            {
                ModelState.AddModelError("", "MÃ NHÂN VIÊN ĐÃ ĐƯỢC SỬ DỤNG");
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
            var ob = db.NhanViens.ToList().FirstOrDefault(q => q.MaNV == id);
            if (ob != null)
            {
                ob.IsDelete = true;
                r_delete = db.SaveChanges() > 0;
            }
            return Json(r_delete);
        }
    }
}