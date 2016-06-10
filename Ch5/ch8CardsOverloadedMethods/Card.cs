using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch8CardsOverloadedMethods
{
    class Card
    {
        Suit suits;
        Value values;
        
        public Card(Suit suit, Value value)
        {
            this.suits = suit;
            this.values = value;
        }

        public string Name { get { return suits + " of " + values; } }

        public static bool DoesCardMatch(Card cardToCheck, Suit suit)
        {
            if (cardToCheck.suits == suit)
                return true;
            else
                return false;
        }

        public static bool DoesCardMatch(Card cardToCheck, Value value)
        {
            if (cardToCheck.values == value)
                return true;
            else
                return false;
        }

    }
}
