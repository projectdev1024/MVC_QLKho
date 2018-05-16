using MVC_QLKHO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_QLKHO.Controllers
{
    public class NhaCungCapController : BaseController
    {
        //
        // GET: /NhaCungCap/
        public ActionResult Index()
        {
            return View(new Models.dbQLKhoEntities().NhaCungCaps.ToList().Where(q => q.IsDelete != true).ToList());
        }

        public ActionResult Edit(string id = null)
        {
            NhaCungCap ob = new NhaCungCap()
            {
                IsDelete = null
            };
            ViewBag.Title = "THÊM MỚI NHÀ CUNG CẤP";
            if (string.IsNullOrEmpty(id) == false)
            {
                ob = new dbQLKhoEntities().NhaCungCaps.ToList().FirstOrDefault(q => q.MaNCC == id);
                if (ob == null) RedirectToAction("Index");
                ViewBag.Title = "SỬA NHÀ CUNG CẤP";
            }
            return View(ob);
        }

        [HttpPost]
        public ActionResult Edit(NhaCungCap ob)
        {
            var db = new dbQLKhoEntities();
            var t_ob = db.NhaCungCaps.ToList().FirstOrDefault(q => q.MaNCC == ob.MaNCC);
            if (t_ob == null)
            {
                ob.IsDelete = false;
                db.NhaCungCaps.Add(ob);
                db.SaveChanges();
            }
            else if (t_ob.IsDelete == true)
            {
                ModelState.AddModelError("", "MÃ NHÀ CUNG CẤP ĐÃ ĐƯỢC SỬ DỤNG");
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
            var ob = db.NhaCungCaps.ToList().FirstOrDefault(q => q.MaNCC == id);
            if (ob != null)
            {
                ob.IsDelete = true;
                r_delete = db.SaveChanges() > 0;
            }
            return Json(r_delete);
        }
    }
}