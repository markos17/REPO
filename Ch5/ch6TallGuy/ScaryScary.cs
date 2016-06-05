using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch6TallGuy
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        public ScaryScary(string funnyThingsIHave, int nrOfScaryThings) : base(funnyThingsIHave)
        {
            this.numberOfScaryThings = nrOfScaryThings;
        }
        private int numberOfScaryThings;
        public string ScaryThingIHave
        {
            get
            {
                return "I have " + numberOfScaryThings + " spiders.";
            }
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine("Boo!Gotcha " );
        }
    }
}
