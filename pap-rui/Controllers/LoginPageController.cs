using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        public ActionResult checkLogin(string emailValue, string passwordValue)
        {
            var result = db.Clientes.Where(x => x.email == emailValue && x.password == passwordValue);


            if (result.Count() > 0)
            {
                Session["login"] = "login";
                Session["userID"] = result.FirstOrDefault().id;
                return RedirectToAction("Index", "dashboard");
            }
            else
            {
                ViewBag.loginFailed = "Dados incorrectos";
                return View("/Views/Login/login.cshtml");
            }
        }
    }
}