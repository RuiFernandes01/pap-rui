using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Configuration;
namespace pap_rui.Controllers.Shared
{
    public class FooterController : Controller
    {
        private iluminarteEntities db = new iluminarteEntities();
        public int contactosID = Convert.ToInt32(WebConfigurationManager.AppSettings["contactosID"]);
        public ActionResult _footer()
        {
            ViewBag.contactostxt = getcontactostxt();
            return PartialView("/Views/Shared/_footer.cshtml");
        }

        public string getcontactostxt()
        {
            texto contactos = db.texto.Where(p => p.id == contactosID).FirstOrDefault();
            return contactos.descrição;
        }
    }
}