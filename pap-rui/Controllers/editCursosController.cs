using pap_rui.Models;
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
            var cursoDB = db.Cursos.Where(x => x.id == cursosToEdit.id).FirstOrDefault();

            if (cursosToEdit.titulo != cursoDB.titulo)
            {
                cursoDB.titulo = cursosToEdit.titulo;
            }
            if (cursosToEdit.subtitulo != cursoDB.subtitulo)
            {
                cursoDB.subtitulo = cursosToEdit.subtitulo;
            }
            if (cursosToEdit.duracao != cursoDB.duracao)
            {
                cursoDB.duracao = cursosToEdit.duracao;
            }
            if (cursosToEdit.descricao != cursoDB.descricao)
            {
                cursoDB.descricao = cursosToEdit.descricao;
            }
            if (cursosToEdit.imagem != null && cursosToEdit.imagem != cursoDB.imagem)
            {
                cursoDB.imagem = cursosToEdit.imagem;
            }

            db.SaveChanges();
        }
    }
}