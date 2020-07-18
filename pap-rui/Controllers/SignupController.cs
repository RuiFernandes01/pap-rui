using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pap_rui.Controllers
{
    public class SignupController : Controller
    {
        public ActionResult Index()
        {
            return View("/Views/Signup/signup.cshtml");
        }

        public ActionResult Registar(Registo obj)

        {
            if (ModelState.IsValid)
            {
                iluminarteEntities db = new iluminarteEntities();
                db.Registo.Add(obj);
                db.SaveChanges();
            }
            return View("/Views/Login/LoginPage.cshtml");
        }
    }
}