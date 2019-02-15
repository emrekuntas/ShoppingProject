using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.UI.Controllers
{
    //AuthorizationUser'ın içindeki kodları çalıştırır otamatik olarak
    [AuthorizationUser]
    public class MusteriController : Controller
    {
        // GET: Musteri
        public ActionResult Odeme()
        {
            return View();
        }
        public ActionResult Takip()
        {
            return View();
        }
    }
}