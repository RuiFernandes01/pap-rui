using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pap_rui.Models
{
    public class CursosModel
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string subtitulo { get; set; }
        public string imagem { get; set; }
        public HttpPostedFileBase imagemFile { get; set; }
        public string duracao { get; set; }
        public string descricao { get; set; }
    }
}