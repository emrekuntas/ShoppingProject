using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.UI
{
    public class AuthorizationGuest : ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            //HttpContext.Current.Session["Kullanici"] = null;
            if (HttpContext.Current.Session["Role"] ==null)
            {
                HttpContext.Current.Session["Role"] = "Guest";
            }
            
        }
    }
}