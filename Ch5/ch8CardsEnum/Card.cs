using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch8CardsEnum
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


    }
}
