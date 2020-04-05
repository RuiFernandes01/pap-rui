using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pap_rui.Controllers
{
    public class dashboardController : Controller
    {
        private iluminarteEntities db = new iluminarteEntities();

        public ActionResult Index()
        {
            if(Session["login"] != null)
            {
                List<eventos> eventosList = getEventosList();

                return View("/Views/dashboard/dashboard.cshtml", eventosList);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public List<eventos> getEventosList()
        {
            List<eventos> listaEventos = db.eventos.ToList();

            return listaEventos;
        }

        [HttpPost]
        public ActionResult delete(int id)
        {
            eventos eventoToRemove = db.eventos.Where(x => x.id == id).FirstOrDefault();
            db.eventos.Remove(eventoToRemove);
            db.SaveChanges();

            List<eventos> eventosList = getEventosList();

            return PartialView("/Views/dashboard/eventosList.cshtml", eventosList);
        }
    }
}