using pap_rui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace pap_rui.Controllers.Home
{
    public class CursosController : Controller
    {
        private iluminarteEntities db = new iluminarteEntities();
        // GET: Cursos
        public ActionResult CursosSlideshow()
        {
            List<Cursos> cursosList = getcursosList();
            return PartialView("/Views/Home/CursosSlideshow.cshtml", getcursosList());
        }

        public List<Cursos> getcursosList() {
            try
            {
                List<Cursos> listaCursos = db.Cursos.ToList();
                return listaCursos;
            }
            catch
            {
                return new List<Cursos>();
            }
        }
    }
}
