using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pap_rui.Methods;
using pap_rui.Models;

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

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult adicionarEventos(Eventos eventoToAdd)
        {
            eventoToAdd.imagem = getImage(eventoToAdd.imagemFile);
            eventoToAdd.modificadoPor = Convert.ToInt32(Session["userID"]);
            db.eventos.Add(generalMethods.ConvertEventToDb(eventoToAdd));
            db.SaveChanges();

            return RedirectToAction("Index", "dashboard");
        }

        public string getImage(HttpPostedFileBase file)
        {
            var path = "";
            if (file != null)
            {
                if (file.ContentLength > 0)
                {
                    if (System.IO.Path.GetExtension(file.FileName).ToLower() == ".jpg"
                        || System.IO.Path.GetExtension(file.FileName).ToLower() == ".png"
                    || System.IO.Path.GetExtension(file.FileName).ToLower() == ".gif"
                        || System.IO.Path.GetExtension(file.FileName).ToLower() == ".jpeg")
                    {
                        path = System.IO.Path.Combine(Server.MapPath("~/images/upload_files"), file.FileName);
                        file.SaveAs(path);
                    }
                    path = "/images/upload_files/" + file.FileName;
                }
            }

            return path;
        }
    }
}