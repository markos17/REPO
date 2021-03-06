﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch8DuckCollection
{
    class Program
    {
          static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>() {
            new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
            new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
            new Duck() { Kind = KindOfDuck.Decoy, Size = 14 },
            new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
            new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
            new Duck() { Kind = KindOfDuck.Decoy, Size = 13 },
            };

            PrintDucks(ducks);

           // ducks.Sort();
            DuckComparerBySize comparer = new DuckComparerBySize();
            ducks.Sort(comparer);
            Console.WriteLine(comparer.Compare(ducks[0], ducks[1]));
            PrintDucks(ducks);

         //   ducks.GetEnumerator()

            Console.ReadKey();
        }



        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
                //    Console.WriteLine(duck.Size.ToString() + "-inch " + duck.Kind.ToString());
                Console.WriteLine(duck);
            Console.WriteLine("end of ducks!");

        }
    }
}
