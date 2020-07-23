using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace pap_rui
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Login",
                url: "login",
                defaults: new { controller = "Login", action = "Index" }
            );

            routes.MapRoute(
                name: "Logout",
                url: "logout",
                defaults: new { controller = "Login", action = "Logout" }
            );

            routes.MapRoute(
                name: "Dashboard",
                url: "dashboard",
                defaults: new { controller = "dashboard", action = "Index" }
            );

            routes.MapRoute(
                name: "savequemsomos",
                url: "savequemsomos",
                defaults: new { controller = "dashboard", action = "savequemsomos" }
            );

            routes.MapRoute(
                name: "saveacademia",
                url: "saveacademia",
                defaults: new { controller = "dashboard", action = "saveacademia" }
            );

            routes.MapRoute(
                name: "savecursos",
                url: "savecursos",
                defaults: new { controller = "dashboard", action = "savecursos" }
            );

            routes.MapRoute(
                name: "savecontactos",
                url: "savecontactos",
                defaults: new { controller = "dashboard", action = "savecontactos" }
            );

            routes.MapRoute(
                name: "addEventos",
                url: "AddEventos",
                defaults: new { controller = "AddEventos", action = "Index" }
            );

            routes.MapRoute(
                name: "addCursos",
                url: "AddCursos",
                defaults: new { controller = "addCursos", action = "Index" }
            );

            routes.MapRoute(
                name: "editEventos",
                url: "{id}/editEventos",
                defaults: new { controller = "editEventos", action = "Index" }
            );

            routes.MapRoute(
                name: "editCursos",
                url: "{id}/editCursos",
                defaults: new { controller = "editCursos", action = "Index" }
            );

            routes.MapRoute(
                name: "Page",
                url: "page/{id}",
                defaults: new { controller = "Page", action = "Index" }
            );

            routes.MapRoute(
                name: "Curso",
                url: "curso/{id}",
                defaults: new { controller = "Page", action = "Curso" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
