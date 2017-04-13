using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ch16BasketballRoster.Model;
using System.Collections.ObjectModel;

namespace ch16BasketballRoster.ViewModel
{
    class LeagueViewModel
    {
        public RoosterViewModel BriansTeam { get; set; }
        public RoosterViewModel JimmyTeam { get; set; }

        public LeagueViewModel()
        {
            Rooster briansRooster = new Rooster("The bOOmbers", GetBomberPlayers());
            BriansTeam = new RoosterViewModel(briansRooster);

            Rooster jimmyRooster = new Rooster("The Amazins", GetAmazingPlayers());
            JimmyTeam = new RoosterViewModel(jimmyRooster);
        }


        private IEnumerable<Player> GetBomberPlayers()
        {
            List<Player> bomberPlayers = new List<Player>();
            bomberPlayers.Add(new Player("Brian", 31, true));
            bomberPlayers.Add(new Player("Lloyd", 23, true));
            bomberPlayers.Add(new Player("Kathleen", 6, true));
            bomberPlayers.Add(new Player("Mike", 0, true));
            bomberPlayers.Add(new Player("Joe", 42, true));
            bomberPlayers.Add(new Player("Herb", 32, false));
            bomberPlayers.Add(new Player("Fingers", 8, false));
            return bomberPlayers;
        }

        private IEnumerable<Player> GetAmazingPlayers()
        {
            List<Player> amazinPlayers = new List<Player>() {
            new Player("Jimmy",42, true),
            new Player("Henry",11, true),
            new Player("Bob",4, true),
            new Player("Lucinda", 18, true),
            new Player("Kim", 16, true),
            new Player("Bertha", 23, false),
            new Player("Ed",21, false),
            };
            return amazinPlayers;
        }

    }
}
