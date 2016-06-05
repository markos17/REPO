using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch6TallGuy
{
    class TallGuy : IClown
    {
        public string Name;
        public int Height;

        public string FunnyThingIHave
        {
            get
            {
                return "big shoes! ;)";
            }
        }

        public void TalkAboutYourself()
        {
            Console.WriteLine("My name is " + Name + " and I am " + Height + "cm height and my shoes are: " + FunnyThingIHave);
        }

        public void Honk()
        {
            Console.WriteLine("Honk! Honk! ");
        }
        
    }
}
