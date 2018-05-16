using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_QLKHO.Models;
using System.Data;
using System.Data.Entity;

namespace MVC_QLKHO.Controllers
{
    public class NhaKhoController : BaseController
    {
        public ActionResult Index()
        {
            return View(new Models.dbQLKhoEntities().NhaKhoes.ToList().Where(q => q.Status != "DaXoa").ToList());
        }

        public ActionResult Edit(int? id = null)
        {
            NhaKho ob = new NhaKho()
            {
                Status = "SanSang"
            };
            ViewBag.Title = "THÊM MỚI NHÀ KHO";
            if (id.HasValue)
            {
                ob = new dbQLKhoEntities().NhaKhoes.ToList().FirstOrDefault(q => q.ID_NhaKho == id);
                if (ob == null) RedirectToAction("Index");
                ViewBag.Title = "SỬA NHÀ KHO";
            }
            return View(ob);
        }

        [HttpPost]
        public ActionResult Edit(NhaKho ob)
        {
            var db = new dbQLKhoEntities();
            db.Entry(ob).State = ob.ID_NhaKho > 0 ? System.Data.Entity.EntityState.Modified : System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public JsonResult Delete(int id)
        {
            var db = new dbQLKhoEntities();
            bool r_delete = false;
            var ob = db.NhaKhoes.ToList().FirstOrDefault(q => q.ID_NhaKho == id);
            if (ob != null)
            {
                ob.Status = "DaXoa";
                r_delete = db.SaveChanges() > 0;
            }
            return Json(r_delete);
        }
	}
}