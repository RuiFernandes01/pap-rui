using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pap_rui.Models
{
    public class Eventos
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string subtitulo { get; set; }
        public string imagem { get; set; }
        public HttpPostedFileBase imagemFile { get; set; }
        public DateTime datainicio { get; set; }
        public DateTime datafim { get; set; }
        public string descricao { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public int modificadoPor { get; set; }
        public virtual Users Users { get; set; }
    }

    public class dashboardModel
    {
        public dashboardModel()
        {
            this.eventosList = new List<eventos>();
            this.cursosList = new List<Cursos>();
        }
        public List<eventos> eventosList { get; set; }
        public List<Cursos> cursosList { get; set; }
    }
}