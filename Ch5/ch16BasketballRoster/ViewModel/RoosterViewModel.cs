using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ch16BasketballRoster.Model;

namespace ch16BasketballRoster.ViewModel
{
    class RoosterViewModel
    {
        public ObservableCollection<PlayerViewModel> Starters;
        public ObservableCollection<PlayerViewModel> Bench;

        private Rooster _rooster;

        private string _teamName;
        public string TeamName
        {
            get { return _teamName; }
            set { _teamName = value; }
        }

        public RoosterViewModel(Model.Rooster roosterModel)
        {
            this._rooster = roosterModel;
            Starters = new ObservableCollection<PlayerViewModel>();
            Bench = new ObservableCollection<PlayerViewModel>();
            TeamName = _rooster.TeamName;

            UpdateRoosters();
        }

        private void UpdateRoosters()
        {
            var startingPlayers = from player in _rooster.Players
                                  where player.Starter == true
                                  select player;

            foreach (Player player in startingPlayers)
            {
                Starters.Add(new PlayerViewModel(player.Name, player.Number));
            }

            //var benchPlayer = _rooster.Players.Where(s => s.Starter == false).Select(player => player);
            //foreach (Player player in benchPlayer)
            //{
            //    Starters.Add(new PlayerViewModel(player.Name, player.Number));
            //}
        }
    }
}
