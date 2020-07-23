using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pap_rui.Controllers
{
    public class editCursosController : Controller
    {
        private iluminarteEntities db = new iluminarteEntities();
        // GET: editCursos
        public ActionResult Index(int id)
        {
            if (Session["login"] != null)
            {
                var CursosToEdit = db.Cursos.Where(x => x.id == id).FirstOrDefault();
                return View("/Views/dashboard/editCursos.cshtml", CursosToEdit);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

            [HttpPost]
        [ValidateInput(false)]
        public ActionResult saveCursos(Cursos cursosToEdit)
        {
            editCursos(cursosToEdit);
            return RedirectToAction("Index", "dashboard");
        }

        public void editCursos(Cursos cursosToEdit)
        {
            var eventDB = db.eventos.Where(x => x.id == cursosToEdit.id).FirstOrDefault();

            if (cursosToEdit.titulo != eventDB.titulo)
            {
                eventDB.titulo = cursosToEdit.titulo;
            }
            if (cursosToEdit.subtitulo != eventDB.subtitulo)
            {
                eventDB.titulo = cursosToEdit.titulo;
            }
            if (cursosToEdit.descricao != eventDB.descricao)
            {
                eventDB.titulo = cursosToEdit.titulo;
            }
            if (cursosToEdit.imagem != null && cursosToEdit.imagem != eventDB.imagem)
            {
                eventDB.imagem = cursosToEdit.imagem;
            }

            db.SaveChanges();
        }
    }
    }