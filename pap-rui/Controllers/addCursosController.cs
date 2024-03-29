﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pap_rui.Methods;
using pap_rui.Models;

namespace pap_rui.Controllers
{
    public class addCursosController : Controller
    {
        private iluminarteEntities db = new iluminarteEntities();
        // GET: addCursos
        public ActionResult Index()
        {
            if (Session["login"] != null)
            {
                return View("/Views/dashboard/addCursos.cshtml");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AdicionarCursos(CursosModel cursoToAdd)
        {
            cursoToAdd.imagem = getImage(cursoToAdd.imagemFile);
            db.Cursos.Add(generalMethods.ConvertCursoToDb(cursoToAdd));
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
                        path = System.IO.Path.Combine(Server.MapPath("~/images/CursosImagens"), file.FileName);
                        file.SaveAs(path);
                    }
                    path = "/images/CursosImagens/" + file.FileName;
                }
            }

            return path;
        }
    }
}