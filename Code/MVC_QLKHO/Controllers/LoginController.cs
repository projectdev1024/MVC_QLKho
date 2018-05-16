using MVC_QLKHO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_QLKHO.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(NhanVien ob)
        {
            if (LoginHelper.Login(ob) == null)
            {
                ModelState.AddModelError("", "Sai tên đăng nhập hoặc mật khẩu.");
            return View();
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            LoginHelper.Logout();
            return RedirectToAction("Index");
        }
	}
}