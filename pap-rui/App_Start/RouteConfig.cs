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
                name: "addEventos",
                url: "AddEventos",
                defaults: new { controller = "AddEventos", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
