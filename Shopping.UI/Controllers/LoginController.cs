using Shopping.BL.DTOs;
using Shopping.UI.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Shopping.BL.BussinessManager;

namespace Shopping.UI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel m)
        {
            try
            {
                UsersManager um = new UsersManager();
                UsersDTO userDTO = um.Denetle(m.User.UserID, m.User.Password);
                Session["Kullanici"] = userDTO.UserID;
                Session["Role"] = userDTO.Role;
                if (Session["Role"].ToString() == "ADMIN")
                {
                    return RedirectToAction("Admin", "Admin");
                }
                else return RedirectToAction("Hata", "Login");
                //return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {

                return RedirectToAction("Login", "Login");
            }
            
        }
        public ActionResult LogOut()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult Hata()
        {

            return View();
        }
    }
}