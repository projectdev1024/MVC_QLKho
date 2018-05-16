using MVC_QLKHO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_QLKHO.Controllers
{
    public class PhieuNhapController : BaseController
    {
        //
        // GET: /PhieuNhap/
        public ActionResult Index(DateTime? TimeStart, DateTime? TimeEnd)
        {
            var data = new dbQLKhoEntities().PhieuNhaps.ToList();
            if (TimeStart.HasValue)
            {
                data = data.Where(q => q.ThoiGian.Value >= TimeStart.Value).ToList();
            }
            if (TimeEnd.HasValue)
            {
                data = data.Where(q => q.ThoiGian.Value <= TimeEnd.Value).ToList();
            }
            return View(data);
        }
    }
}