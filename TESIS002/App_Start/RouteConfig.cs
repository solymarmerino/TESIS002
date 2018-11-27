using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TESIS002
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           /*routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional }
            );*/

            /*routes.MapRoute(
               name: "IngresarServicioPersonal",
               url: "Personal/Ingresar/{IdPersonal}",
               defaults: new { controller = "Personal", action = "Ingresar", id = UrlParameter.Optional }
            );*/

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional }
            );
        }
    }
}
