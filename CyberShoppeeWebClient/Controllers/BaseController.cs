using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberShoppeeWebClient.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Session["user"] == null)
            {
                filterContext.Result = new RedirectResult("/Account/Login");
            }
            base.OnActionExecuting(filterContext);
        }
    }
}