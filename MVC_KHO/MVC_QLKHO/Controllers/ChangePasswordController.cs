using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_QLKHO.Models;

namespace MVC_QLKHO.Controllers
{
    public class ChangePasswordController : BaseController
    {
        //
        // GET: /ChangePassword/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string oldpass, string newpass, string repass)
        {
            bool validate = true;
            if (newpass.Equals(repass) == false)
            {
                ModelState.AddModelError("", "Vui lòng xác nhận mật khẩu trùng với mật khẩu mới.");
                validate = false;
            }
            if (newpass.Length < 8)
            {
                ModelState.AddModelError("", "Vui lòng xác nhận mật khẩu mới có ít nhất 08 kí tự.");
                validate = false;
            }
            if (validate)
            {
                var db = new dbQLKhoEntities();
                var acc = db.NhanViens.ToList().FirstOrDefault(q => q.MaNV.Equals(LoginHelper.GetAccount().MaNV));
                if (acc.MatKhau.Equals(oldpass))
                {
                    acc.MatKhau = newpass;
                    db.SaveChanges();
                    return RedirectToAction("Logout", "Login");
                }
                else
                {
                    ModelState.AddModelError("", "Mật khẩu cũ không chính xác.");
                }
            }
            return View();
        }
    }
}