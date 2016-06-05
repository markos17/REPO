using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch6TallGuy
{
    class FunnyFunny : IClown
    {
        public FunnyFunny(string funnyThingsIHave)
        {
            this.funnyThingIHave = funnyThingsIHave;
        }

        private string funnyThingIHave;
        public string FunnyThingIHave
        {
            get
            {
                return ("Hi kids! I have a " + FunnyThingIHave); ;
            }
        }

        public void Honk()
        {
            Console.WriteLine(this.FunnyThingIHave);
        }
    }
}
