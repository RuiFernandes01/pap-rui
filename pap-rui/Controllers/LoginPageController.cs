using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using pap_rui.Models;

namespace pap_rui.Controllers
{
    public class LoginPageController : Controller
    {

        private iluminarteEntities db = new iluminarteEntities();
        // GET: LoginPage
        public ActionResult Index()
        {
            return View("/Views/Login/LoginPage.cshtml");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel account)
        {
            var accountToAdd = ConvertModelToRegisto(account);
            if (ModelState.IsValid)
            {
                using (iluminarteEntities db = new iluminarteEntities())
                {
                    db.Registo.Add(accountToAdd);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.FirstName + "" + account.LastName + "Registado com sucesso";

                
            }

            return View();

            
        }

        //Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Login(RegisterModel user)
        {
            using (iluminarteEntities db = new iluminarteEntities())
            {
                var usr = db.Registo.Single(u => u.Email == user.Email && u.Password == user.Password);
                if (usr != null)
                {
                    Session["login"] = "user";
                    Session["id"] = usr.id.ToString();
                    Session["Email"] = usr.Email.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Email ou passoword não correspondem");
                }
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["id"]!= null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public Registo ConvertModelToRegisto(RegisterModel oldRegisto)
        {
            Registo newRegisto = new Registo();

            newRegisto.Email = oldRegisto.Email;
            newRegisto.Password = oldRegisto.Password;
            newRegisto.ConfirmPassword = oldRegisto.ConfirmPassword;
            newRegisto.FirstName = oldRegisto.FirstName;
            newRegisto.LastName = oldRegisto.LastName;

            return newRegisto;
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}