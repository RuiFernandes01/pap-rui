using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace pap_rui.Controllers
{
    public class dashboardController : Controller
    {
        private iluminarteEntities db = new iluminarteEntities();
        public int quemSomosID = Convert.ToInt32(WebConfigurationManager.AppSettings["quemsomosID"]);
        public int academiaID = Convert.ToInt32(WebConfigurationManager.AppSettings["academiaID"]);
        public int cursosID = Convert.ToInt32(WebConfigurationManager.AppSettings["cursosID"]);
        public int contactosID = Convert.ToInt32(WebConfigurationManager.AppSettings["contactosID"]);
        public ActionResult Index()
        {
            if(Session["login"] != null)
            {
                texto quemSomos = db.texto.Where(p => p.id == quemSomosID).FirstOrDefault();
                ViewBag.quemSomosTxt = quemSomos.descrição;

                texto academia = db.texto.Where(p => p.id == academiaID).FirstOrDefault();
                ViewBag.academiatxt = academia.descrição;

                texto cursos = db.texto.Where(p => p.id == cursosID).FirstOrDefault();
                ViewBag.cursostxt = cursos.descrição;

                texto contactos = db.texto.Where(p => p.id == contactosID).FirstOrDefault();
                ViewBag.contactos = contactos.descrição;

                List<eventos> eventosList = getEventosList();
                return View("/Views/dashboard/dashboard.cshtml", eventosList);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult savequemsomos(string quemsomostxt)
        {
            texto quemSomos = db.texto.Where(p => p.id == quemSomosID).FirstOrDefault();
            quemSomos.descrição = quemsomostxt;
            db.SaveChanges();
            return RedirectToAction("Index", "dashboard");
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult saveacademia(string academiatxt)
        {
            texto academia = db.texto.Where(p => p.id == academiaID).FirstOrDefault();
            academia.descrição = academiatxt;
            db.SaveChanges();
            return RedirectToAction("Index", "dashboard");
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult savecursos(string cursostxt)
        {
            texto cursos = db.texto.Where(p => p.id == cursosID).FirstOrDefault();
            cursos.descrição = cursostxt;
            db.SaveChanges();
            return RedirectToAction("Index", "dashboard");
        }


        [HttpPost]
        [ValidateInput(false)]
        public ActionResult savecontactos(string contactostxt)
        {
            texto contactos = db.texto.Where(p => p.id == contactosID).FirstOrDefault();
            contactos.descrição = contactostxt;
            db.SaveChanges();
            return RedirectToAction("Index", "dashboard");
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