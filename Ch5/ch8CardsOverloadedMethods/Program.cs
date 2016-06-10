using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch8CardsOverloadedMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Card cardToCheck = new Card(Suit.Clubs, Value.Three);
            bool doesItMatch = Card.DoesCardMatch(cardToCheck, Value.Ace);
            Console.WriteLine(doesItMatch);
            Console.ReadLine();
        }
    }
}
