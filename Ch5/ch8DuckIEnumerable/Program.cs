using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch8DuckIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>(){
            new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
            new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
            new Duck() { Kind = KindOfDuck.Decoy, Size = 14 },
            new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
            new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
            new Duck() { Kind = KindOfDuck.Decoy, Size = 13 },
            };

            IEnumerable<Bird> upcastDuck = ducks;

            List<Bird> birds = new List<Bird>();
            birds.Add(new Bird() { Name = "Feathers" });
            birds.AddRange(upcastDuck);
            birds.Add(new Penguin() { Name = "Pingwinek" });
            foreach (Bird ptak in birds)
            {
                Console.WriteLine(ptak);
            }
            Console.ReadLine();
        }
    }
}
