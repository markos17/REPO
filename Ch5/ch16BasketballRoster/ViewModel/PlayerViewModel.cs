﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch16BasketballRoster.ViewModel
{
    class PlayerViewModel
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public PlayerViewModel(string name, int number)
        {
            this.Name = name;
            this.Number = number;
        }
    }
}
