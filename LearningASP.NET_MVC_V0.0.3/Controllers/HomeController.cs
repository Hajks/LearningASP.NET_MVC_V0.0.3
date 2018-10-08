using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LearningASP.NET_MVC_V0._0._3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            //1 - przykład //  return Server.HtmlEncode("Hello, ASP.NET MVC!"); //Returning string without encoding might be dangerous for user, because it can be changed for any type of script.

            //2 -- przykład//  //string result = "";

            //foreach (string routekey in RouteData.Values.Keys)
            //{
            //    result += "Key: " + routekey + " Value: " + RouteData.Values[routekey] as string;
            //    result += "<br />";
            //}

            //return result; 

            var getPath = RouteTable.Routes.GetVirtualPath(null,
                new RouteValueDictionary(new
                {
                    controller = "Kontroler",
                    action = "Akcja",
                    id = "12",
                    parametr = "Bartek"                
                }));
            string urlReady = getPath.VirtualPath;
            return urlReady;

        }
    }
}