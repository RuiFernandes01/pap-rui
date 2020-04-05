using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pap_rui.Controllers
{
    public class AddEventosController : Controller
    {
        // GET: AddEventos
        public ActionResult Index()
        {
            return View("/Views/dashboard/addEvento.cshtml");
        }
    }
}