using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ch1_4_ReturnDimensions();
            //TestCh1_10();
            TestCh1_11();
        }

        private static void Ch1_4_ReturnDimensions()
        {
            int height;
            int width;
            int depth;

            Dimension obj = new Dimension();
            obj.ReturnDimension(2, out height, out width, out height);
            Console.WriteLine(height);
            Console.ReadLine();
        }

        public static void TestCh1_10()
        {
            Ch1_10_FixedSizeCollection fixA = new Ch1_10_FixedSizeCollection(2);
            Console.WriteLine(fixA);
            Ch1_10_FixedSizeCollection fixB = new Ch1_10_FixedSizeCollection(3);
            Console.WriteLine(fixB);

            Ch1_10_FixedSizeCollection_Generic<bool> genA = new Ch1_10_FixedSizeCollection_Generic<bool>(2);
            Console.WriteLine(genA);
            Ch1_10_FixedSizeCollection_Generic<int> genB = new Ch1_10_FixedSizeCollection_Generic<int>(3);
            Console.WriteLine(genB);

            bool b1 = true;
            bool b2 = false;
            bool bHolder = true;

            fixA.AddItem(b1);
            fixA.AddItem(b2);
            //a.AddItem(bHolder);
            bHolder = (bool)fixA.GetItem(1);

            genA.AddItem(b1);
            genA.AddItem(b2);

            int i1 = 1;
            int i2 = 2;
            int i3 = 3;

            fixB.AddItem(i1);
            fixB.AddItem(i2);
            fixB.AddItem(i3);

            genB.AddItem(i1);
            genB.AddItem(i2);
            genB.AddItem(i3);

            Console.WriteLine(fixA);
            Console.WriteLine(fixB);

            Console.WriteLine(genA);
            Console.WriteLine(genB);
        }
        public static void TestCh1_11()
        {
            var lista = Ch1_11_SortedListDesc.data;
            foreach (KeyValuePair<int, string> kvp in lista)
            {
                Console.WriteLine($"\t {kvp.Key}\t{kvp.Value}");  
                Console.WriteLine();              
            }

            var odwroconaLista = lista.OrderByDescending(k => k.Key);
            foreach (KeyValuePair<int, string> kvp in odwroconaLista)
            {
                Console.WriteLine($"\t {kvp.Key}\t{kvp.Value}");
            }
            Console.ReadLine();
        }

    }
}
