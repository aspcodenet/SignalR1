//(C) Stefan Holmberg 2013
// http://stefanholmberg.com
//MIT license - use however you'd like...


using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Microsoft.AspNet.SignalR;
using SignalRWeb.Impl;

namespace SignalRWeb.Controllers
{
    public class PushGameDataController : Controller
    {
        public void SendMessage(int gameid, string message)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<HockeyHub>();
            context.Clients.Group(gameid.ToString()).add(message);
        }

    }
}
