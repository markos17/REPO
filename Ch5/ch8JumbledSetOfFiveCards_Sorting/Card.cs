using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch8JumbledSetOfFiveCards_Sorting
{
    class Card
    {
        public Suit suit;
        public Value value;
        
        public Card(Suit suit, Value value)
        {
            this.suit = suit;
            this.value = value;
        }

        public string Name { get { return suit + " of " + value; } }

        public override string ToString()
        {
            return Name;
        }
    }
}
