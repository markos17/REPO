using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch7houseHideAndSeek
{
    abstract class Location
    {
        public Location(string name)
        {
            this.Name = name;
        }
        public Location[] Exits;
        public string Name { get; private set; }
        public virtual string Description
        {
            get
            {
                string description = string.Empty;
                description += "You're standing in the " + Name + ". You see exits to the following places: \n";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += Exits[i].Name;
                    if (i != Exits.Length - 1)
                        description += ",";
                }
                description += ".";
                return description;
            }
        }
    }
}
