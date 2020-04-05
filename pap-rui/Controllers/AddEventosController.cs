using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pap_rui.Controllers
{
    public class AddEventosController : Controller
    {
        private iluminarteEntities db = new iluminarteEntities();
        public ActionResult Index()
        {
            if (Session["login"] != null)
            {
                return View("/Views/dashboard/addEvento.cshtml");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }


        public ActionResult adicionarEventos(eventos teste)
        {

            db.eventos.Add(teste);
            db.SaveChanges();

            return RedirectToAction("Index", "dashboard");
        }
    }
}