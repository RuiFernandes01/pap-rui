using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pap_rui.Controllers.Shared
{
    public class NavbarController : Controller
    {
        public ActionResult _navbar()
        {
            return PartialView("/Views/Shared/_navbar.cshtml");
        }
    }
}