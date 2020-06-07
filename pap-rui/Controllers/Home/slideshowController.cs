using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pap_rui.Controllers.Home
{
    public class slideshowController : Controller
    {
        private iluminarteEntities db = new iluminarteEntities();
        public ActionResult _slideshow()
        {
            List<eventos> eventList = getEventosList();
            return PartialView("/Views/Home/_slideshow.cshtml", eventList);
        }

        public List<eventos> getEventosList()
        {
            try
            {
                List<eventos> listaEventos = db.eventos.ToList();

                return listaEventos;
            }
            catch
            {
                return new List<eventos>();
            }
        }
    }
}