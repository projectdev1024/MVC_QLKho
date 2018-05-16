using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_QLKHO.Models
{
    public static class LoginHelper
    {
        public static NhanVien GetAccount()
        {
            return HttpContext.Current.Session["LOGIN"] as NhanVien;
        }

        public static NhanVien Login(NhanVien ob)
        {
            var r_nhanvien = new dbQLKhoEntities().NhanViens.ToList().FirstOrDefault(q => q.MaNV.Equals(ob.MaNV) && q.MatKhau.Equals(ob.MatKhau) && q.IsDelete != true);
            if (r_nhanvien != null)
            {
                HttpContext.Current.Session["LOGIN"] = r_nhanvien;
            }
            return r_nhanvien;
        }

        public static void Logout()
        {
            HttpContext.Current.Session["LOGIN"] = null;
        }
    }
}