using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pap_rui.Controllers
{
    public class LoginController : Controller
    {
        private iluminarteEntities db = new iluminarteEntities();
        public ActionResult Index()
        {
            return View("/Views/Login/login.cshtml");
        }

        public ActionResult checkLogin(string emailValue, string passwordValue)
        {
            var result = db.Users.Where(x => x.email == emailValue && x.password == passwordValue);


            if(result.Count() > 0)
            {
                Session["login"] = "admin";
                Session["userID"] = result.FirstOrDefault().id;
                return RedirectToAction("Index","dashboard");
            }
            else
            {
                ViewBag.loginFailed = "Dados incorrectos";
                return View("/Views/Login/login.cshtml");
            }
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return View("/Views/Login/login.cshtml");
        }
    }
}