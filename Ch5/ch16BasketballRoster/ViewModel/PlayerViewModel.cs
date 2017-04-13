    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch16BasketballRoster.ViewModel
{
    class PlayerViewModel
    {
        public string Name;
        public int Number;

        public PlayerViewModel(string name, int number)
        {
            this.Name = name;
            this.Number = number;
        }
    }
}
