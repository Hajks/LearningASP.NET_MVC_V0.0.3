using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LearningASP.NET_MVC_V0._0._3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes(); // It allows to read information about route from Controllers.

            routes.MapRoute(
                name: "ProductDetails",
                url: "album-{id}.html",
                defaults: new {controller = "Store", action = "Details"}
                );

            routes.MapRoute(
                name: "ProductList",
                url: "gatunki/{genrename}",
                defaults: new {controller = "Store", action = "List"},
                constraints: new {genrename = @"[\w& ]+"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

            );
        }
    }
}
