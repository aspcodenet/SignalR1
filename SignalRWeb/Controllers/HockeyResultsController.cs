//(C) Stefan Holmberg 2013
// http://stefanholmberg.com
//MIT license - use however you'd like...


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SignalRWeb.Models;
using SignalRWeb.ViewModels;

namespace SignalRWeb.Controllers
{
    public class HockeyResultsController : Controller
    {
        //
        // GET: /HockeyResults/

        public ActionResult Index()
        {
            var model = new GamesListViewModel{ Games=Game.ActiveGames };
            return View(model);
        }

        public ActionResult ShowGame(int gameid)
        {
            var model = new ShowGameViewModel { Game = Game.ActiveGames.First(p=>p.ID == gameid) };
            return View(model);
        }
    }
}
