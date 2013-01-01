//(C) Stefan Holmberg 2013
// http://stefanholmberg.com
//MIT license - use however you'd like...


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SignalRWeb
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
