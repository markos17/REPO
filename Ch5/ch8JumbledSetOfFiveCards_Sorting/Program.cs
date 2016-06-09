using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch8JumbledSetOfFiveCards_Sorting
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Card> cardList = new List<Card>();
            Console.WriteLine("Five random cards:");
            for (int i = 0; i < 5; i++)
            {
                cardList.Add(new Card((Suit)random.Next(4), (Value)random.Next(1, 14)));
                Console.WriteLine(cardList[i].Name);
            }
            CardComparer_byValue compare = new CardComparer_byValue();
            cardList.Sort(compare);
            Console.WriteLine("\nFive sorted cards:");
            foreach (Card card in cardList)
            {
                // Console.WriteLine(card.Name);
                Console.WriteLine(card);
            }          

            

            Console.ReadLine();
        }

        
    }
}
