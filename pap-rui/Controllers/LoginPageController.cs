using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pap_rui.Controllers
{
    public class LoginPageController : Controller
    {
        // GET: LoginPage
        public ActionResult Index()
        {
            return View("/Views/Login/LoginPage.cshtml");
        }
    }
}