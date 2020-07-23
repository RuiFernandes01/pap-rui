using pap_rui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pap_rui.Methods
{
    public static class generalMethods
    {
        public static eventos ConvertEventToDb(Eventos oldEvento)
        {
            eventos newEvento = new eventos();
            newEvento.id = oldEvento.id;
            newEvento.titulo = oldEvento.titulo;
            newEvento.imagem = oldEvento.imagem;
            newEvento.latitude = oldEvento.latitude;
            newEvento.longitude = oldEvento.longitude;
            newEvento.modificadoPor = oldEvento.modificadoPor;
            newEvento.datafim = oldEvento.datafim;
            newEvento.datainicio = oldEvento.datainicio;
            newEvento.descricao = oldEvento.descricao;
            newEvento.subtitulo = oldEvento.subtitulo;
            newEvento.Users = oldEvento.Users;

            return newEvento;
        }

        public static Eventos ConvertEventToModel(eventos oldEvento)
        {
            Eventos newEvento = new Eventos();
            newEvento.id = oldEvento.id;
            newEvento.titulo = oldEvento.titulo;
            newEvento.imagem = oldEvento.imagem;
            newEvento.latitude = oldEvento.latitude;
            newEvento.longitude = oldEvento.longitude;

            newEvento.modificadoPor = oldEvento.modificadoPor;
            newEvento.datafim = oldEvento.datafim;
            newEvento.datainicio = oldEvento.datainicio;
            newEvento.descricao = oldEvento.descricao;
            newEvento.subtitulo = oldEvento.subtitulo;
            newEvento.Users = oldEvento.Users;

            return newEvento;
        }

        public static Cursos ConvertCursoToDb(CursosModel oldCurso)
        {
            Cursos newCurso = new Cursos();
            newCurso.id = oldCurso.id;
            newCurso.titulo = oldCurso.titulo;
            newCurso.imagem = oldCurso.imagem;
            newCurso.duracao = oldCurso.duracao;
            newCurso.descricao = oldCurso.descricao;
            newCurso.subtitulo = oldCurso.subtitulo;

            return newCurso;
        }

        public static CursosModel ConvertCursoToModel(Cursos oldCurso)
        {
            CursosModel newCurso = new CursosModel();
            newCurso.id = oldCurso.id;
            newCurso.titulo = oldCurso.titulo;
            newCurso.imagem = oldCurso.imagem;

            newCurso.descricao = oldCurso.descricao;
            newCurso.duracao = oldCurso.duracao;
            newCurso.subtitulo = oldCurso.subtitulo;

            return newCurso;
        }
    }
}