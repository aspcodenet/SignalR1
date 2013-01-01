//(C) Stefan Holmberg 2013
// http://stefanholmberg.com
//MIT license - use however you'd like...



using System.Collections.Generic;

namespace SignalRWeb.Models
{
    public class Team
    {
        public string Name { get; set; }


        //Fake...just using statics...
        private static List<Team> _allTeams = null;
        public static List<Team> AllTeams
        {
            get
            {
                if (_allTeams == null)
                {
                    _allTeams = new List<Team> { 
                        new Team { Name = "Washington Capitals" }, 
                        new Team { Name = "Boston Bruins" },
                        new Team{Name="New York Rangers"},
                        new Team{Name="New Jersey Devils"},
                        new Team{Name="San Jose Sharks"},
                        new Team{Name="Detroit Red Wings"}
                    };
                }
                
                return _allTeams;
            }
        }
    }
}