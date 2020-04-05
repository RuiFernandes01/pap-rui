using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pap_rui.Controllers.Shared
{
    public class FooterController : Controller
    {
        // GET: Footer
        public ActionResult _footer()
        {
            return PartialView("/Views/Shared/_footer.cshtml");
        }
    }
}