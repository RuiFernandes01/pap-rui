using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registration.Models;

namespace pap_rui.Controllers
{
    public class SignupController : Controller
    {
        public ActionResult Index()
        {
            return View("/Views/Signup/signup.cshtml");
        }

        public ActionResult Index(registo obj)

        {
            if (ModelState.IsValid)
            {
                RegMVCEntities db = new RegMVCEntities();
                db.tblRegistrations.Add(obj);
                db.SaveChanges();
            }
            return View(obj);
        }
    }
}