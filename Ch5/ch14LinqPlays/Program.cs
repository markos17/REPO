using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ch14LinqPlays
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////
            string[] sandwiches = { "Ham and cheese", "salami and mayo", "turkey and swiss", "chicken cutlet" };
            var sandwichesOnRye = from sandwich in sandwiches select sandwich + " on rye";
            foreach (var sandwich in sandwichesOnRye)
            {
                Console.WriteLine(sandwich);
            }
            ////////////
            Random random = new Random();
            List<int> listOfNumbers = new List<int>();
            int length = random.Next(50, 150);
            for (int i = 0; i < length; i++)
            {
                listOfNumbers.Add(random.Next(100));
                Console.WriteLine("There are {0} numbers", listOfNumbers.Count);
                Console.WriteLine("The smallest is {0}", listOfNumbers.Min());
                Console.WriteLine("The biggest is {0}", listOfNumbers.Max());
                Console.WriteLine("The sum is {0}", listOfNumbers.Sum());
                Console.WriteLine("The average is {0}", listOfNumbers.Average());
            }
            ///////////////
            var under50sorted =
                from number in listOfNumbers
                where number < 50
                orderby number descending
                select number;

            List<int> newList = under50sorted.ToList();
            var firstFive = under50sorted.Take(5);
            List<int> shortList = firstFive.ToList();
            foreach (int n in shortList)
            {
                Console.WriteLine(n);
            }


            //LINQ Magnets Solution
            int[] badgers = { 36, 5, 91, 3, 41, 69, 8 };
            var skunks = from pigeon in badgers
                         where (pigeon != 36 && pigeon < 50)
                         orderby pigeon descending
                         select pigeon + 5;
            var bears = skunks.Take(3);
            var weasels = from sparrow in bears
                          select sparrow - 1;

            Console.WriteLine("Get your kicks on route {0}", weasels.Sum());



            //Pool puzzle
            Line[] lines = {
            new Line( new string[] { "eating", "carrots,","but", "enjoy", "Horses" } , 1),
            new Line( new string[] { "zebras?", "hay","Cows", "bridge.", "bolted" } , 2),
            new Line( new string[] { "fork", "dogs!","Engine", "and" }, 3 ) ,
            new Line( new string[] { "love" , "they","apples.", "eating" }, 2 ) ,
            new Line( new string[] { "whistled.", "Bump" }, 1 ) };

            var words = from line in lines
                group line by line.Value
                into wordGroups
                orderby wordGroups.Key
                select wordGroups;
            var twoGroups = words.Take(2);

            foreach (var group in twoGroups)
            {
                int i = 0;
                foreach (var line in group)
                {
                    i++;
                    if (i == group.Key)
                    {
                        var poem =
                            from word in line.Words
                            orderby word descending
                            select word + " ";

                          
                        foreach (var word in poem)
                        {
                            Console.WriteLine(word);
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }

    class Line
    {
        public string[] Words;
        public int Value;

        public Line(string[] Words, int Value)
        {
            this.Words = Words;
            this.Value = Value;
        }
    }
}
