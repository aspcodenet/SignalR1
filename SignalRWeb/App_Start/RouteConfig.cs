//(C) Stefan Holmberg 2013
// http://stefanholmberg.com
//MIT license - use however you'd like...


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SignalRWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "HockeyResults", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}