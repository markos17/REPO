using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch6TallGuy
{
    class Program
    {
        static void Main(string[] args)
        {
            //TallGuy guy = new TallGuy() { Height = 175, Name = "Jimmy" };
            //guy.TalkAboutYourself();
            //guy.Honk();
            //Console.ReadLine();

            ScaryScary fingersTheClown = new ScaryScary("big shoes", 14);
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;

            IScaryClown fingersTheClown1 = new ScaryScary("big shoes", 14);
            //  someOtherScaryClown.Honk();
            fingersTheClown.ScareLittleChildren();
            Console.ReadKey();
        }
    }
}
