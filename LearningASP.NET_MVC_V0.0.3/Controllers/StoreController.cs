using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningASP.NET_MVC_V0._0._3.Controllers
{

    [RoutePrefix("prefiks")]//for example now, if we want to use method Attr our route will be like /prefiks/param(any number)
    public class StoreController : Controller
    {

        [Route("to/jest/{moja}/trasa")]
        public string Index(string moja)
        {
            return "Attribute routing";
        }

        [Route("{param:int}")]
        public string Attr(string param)
        {
            return param;
        }
    }
}