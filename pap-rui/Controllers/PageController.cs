using pap_rui.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pap_rui.Controllers
{
    public class PageController : Controller
    {
        private iluminarteEntities db = new iluminarteEntities();
        public ActionResult Index(int id)
        {
            var evento = generalMethods.ConvertEventToModel(db.eventos.Where(x => x.id == id).FirstOrDefault());

            return View("/Views/Page/_eventoPage.cshtml", evento);
        }
    }
}