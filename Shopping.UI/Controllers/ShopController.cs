using Shopping.UI.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Shopping.BL.BussinessManager;

namespace Shopping.UI.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop

        static KategoriModel model = new KategoriModel();
        public ActionResult StartShop()
        {
            CategoriesManager cm = new CategoriesManager();
            model.clist = cm.KategoriListe();
            return View(model);
        }
        public ActionResult StartProduct(int id)
        {
            ProductsManager pm = new ProductsManager();
            model.plist = pm.UrunListe().Where(x=>x.CategoryID==id).ToList();
            return RedirectToAction("StartShop",model);
        }
    }
}