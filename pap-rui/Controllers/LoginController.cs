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
            var resultValue = db.Users.Where(x => x.email == emailValue && x.password == passwordValue).Count();

            if(resultValue > 0)
            {
                Session["login"] = "login";
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