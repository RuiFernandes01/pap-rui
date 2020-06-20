using pap_rui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pap_rui.Controllers
{
    public class editEventosController : Controller
    {
        private iluminarteEntities db = new iluminarteEntities();
        public ActionResult Index(int id)
        {
            if (Session["login"] != null)
            {
                var eventoToEdit = db.eventos.Where(x => x.id == id).FirstOrDefault();
                return View("/Views/dashboard/editEvento.cshtml", eventoToEdit);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult saveEventos(Eventos eventoToEdit)
        {
            editEvento(eventoToEdit);
            return RedirectToAction("Index", "dashboard");
        }

        public void editEvento(Eventos eventoToEdit)
        {
            var eventDB = db.eventos.Where(x => x.id == eventoToEdit.id).FirstOrDefault();

            if(eventoToEdit.titulo != eventDB.titulo)
            {
                eventDB.titulo = eventoToEdit.titulo;
            }
            if (eventoToEdit.subtitulo != eventDB.subtitulo)
            {
                eventDB.titulo = eventoToEdit.titulo;
            }
            if (eventoToEdit.descricao != eventDB.descricao)
            {
                eventDB.titulo = eventoToEdit.titulo;
            }
            if (eventoToEdit.datainicio != eventDB.datainicio)
            {
                eventDB.datainicio = eventoToEdit.datainicio;
            }
            if (eventoToEdit.datafim != eventDB.datafim)
            {
                eventDB.datafim = eventoToEdit.datafim;
            }
            if (eventoToEdit.imagem != null && eventoToEdit.imagem != eventDB.imagem)
            {
                eventDB.imagem = eventoToEdit.imagem;
            }

            db.SaveChanges();
        }
    }
}