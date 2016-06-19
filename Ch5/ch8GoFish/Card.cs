using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch8GoFish
{
    class Card
    {
        public Suit Suit;
        public Value Value;
        
        public Card(Suit suit, Value value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public string Name { get { return Suit + " of " + Value; } }

        public static string Plural(Value value)
        {
            if (value == Value.Six)
                return "Sixes";
            else
                return value.ToString() + "s";
        }

    }


}
