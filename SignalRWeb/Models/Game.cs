//(C) Stefan Holmberg 2013
// http://stefanholmberg.com
//MIT license - use however you'd like...



using System;
using System.Collections.Generic;

namespace SignalRWeb.Models
{
    public class Game
    {
        public int ID { get; set; }
        public Team Home { get; set; }
        public Team Away { get; set; }

        //Fake...just using statics...
        private static List<Game> _games = null;
        public static List<Game> ActiveGames
        {
            get
            {
                if(_games == null)
                {
                    _games = SetupGames();
                }
                return _games;
            }
        }

        private static List<Game> SetupGames()
        {
            var ret = new List<Game>();

            var randomizer = new Random();
            var allTeams = new List<Team>();
            foreach (var team in Team.AllTeams)
                allTeams.Insert( randomizer.Next(0,allTeams.Count), team);

            int gamesToCreate = Team.AllTeams.Count/2;
            for (int i = 0; i < gamesToCreate; i++ )
            {
                ret.Add(new Game { ID = i + 1000, Home = allTeams[i * 2], Away = allTeams[i * 2 +1] });
            }
            


                return ret;
        }
    }
}