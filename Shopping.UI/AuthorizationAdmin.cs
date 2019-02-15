using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.UI
{
    public class AuthorizationAdmin : ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (HttpContext.Current.Session["Role"].ToString() != "ADMIN")
            {
                //Bu sayfaya gitme yetkiniz yok diye bir sayfa oluşturur
                //filterContext.Result = new  HttpUnauthorizedResult();
                HttpContext.Current.Session["ErrorMessage"] = "Bu Sayfaya girme yetkiniz yok.";
                filterContext.Result = new RedirectResult("/Login/Login");
            }
            //else if (HttpContext.Current.Session["Role"].ToString() == "ADMIN")
            //{
            //    filterContext.Result = new RedirectResult("/Admin/Admin");
            //}
        }
    }
}