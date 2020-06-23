using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace pap_rui.Controllers
{
    public class HomeController : Controller
    {
        private iluminarteEntities db = new iluminarteEntities();
        public int quemSomosID = Convert.ToInt32(WebConfigurationManager.AppSettings["quemsomosID"]);
        public int academiaID = Convert.ToInt32(WebConfigurationManager.AppSettings["academiaID"]);
        public int cursosID = Convert.ToInt32(WebConfigurationManager.AppSettings["cursosID"]);
        
        public ActionResult Index()
        {
            ViewBag.quemSomosTxt = getQuemSomosTxt();
            ViewBag.academiatxt = getacademiatxt();
            ViewBag.cursostxt = getcursostxt();
            
            return View();

        }


        public string getQuemSomosTxt()
        {
            texto quemSomos = db.texto.Where(p => p.id == quemSomosID).FirstOrDefault();
            return quemSomos.descrição;
        }

        public string getacademiatxt()
        {
            texto academia = db.texto.Where(p => p.id == academiaID).FirstOrDefault();
            return academia.descrição;
        }

        public string getcursostxt()
        {
            texto cursos = db.texto.Where(p => p.id == cursosID).FirstOrDefault();
            return cursos.descrição;
        }


    }
}