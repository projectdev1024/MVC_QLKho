using MVC_QLKHO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_QLKHO.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var nhanvien = LoginHelper.GetAccount();
            if (nhanvien == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary(new
                {
                    controller = "Login",
                    action = "Index"
                }));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}