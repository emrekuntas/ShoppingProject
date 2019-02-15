using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.UI
{
    //Annotation
    public class AuthorizationUser : ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (HttpContext.Current.Session["Kullanici"]==null)
            {
                //Bu sayfaya gitme yetkiniz yok diye bir sayfa oluşturur
                //filterContext.Result = new  HttpUnauthorizedResult();
                HttpContext.Current.Session["ErrorMessage"] = "Bu Sayfaya girme yetkiniz yok.";
                filterContext.Result = new RedirectResult("/Login/Login");
            }
        }
    }
}