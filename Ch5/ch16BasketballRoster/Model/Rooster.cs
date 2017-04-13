using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch16BasketballRoster.Model
{
    class Rooster
    {
        public string TeamName { get; private set; }

        private readonly List<Player> _players = new List<Player>();

        public IEnumerable<Player> Players
        {
            get { return new List<Player>(_players); }
        }

        public Rooster(string teamName, IEnumerable<Player> players)
        {
            this.TeamName = teamName;
            _players.AddRange(players);
        }
    }
}
