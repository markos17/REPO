using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch15DelegateRestaurantWinForm
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertIntToString someMethod = new ConvertIntToString(HiThere);
            string msg = someMethod(123);
            //string msg = HiThere(11);
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        private static string HiThere(int i)
        {
            return "Hi there! #" + (i * 100);
        }
    }
}
