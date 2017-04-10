using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch13Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Canine spotKlasa = new Canine("Spot", "pug");
            Canine bob = spotKlasa;
            bob.Name = "Spike";
            bob.Breed = "beagle";
            spotKlasa.Speak();

            Dog alaStruct = new Dog("Ala", "suczka");
            Dog wiola = alaStruct;
            wiola.Name = "Wiola";
            wiola.Breed = "rasowa";
            alaStruct.Speak();

            Console.ReadKey();
        }
    }
}
