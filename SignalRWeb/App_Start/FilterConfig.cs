//(C) Stefan Holmberg 2013
// http://stefanholmberg.com
//MIT license - use however you'd like...



using System.Web;
using System.Web.Mvc;

namespace SignalRWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}