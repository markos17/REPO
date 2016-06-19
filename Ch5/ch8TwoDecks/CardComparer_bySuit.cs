using System;
using System.Collections.Generic;

namespace ch8TwoDecks
{
    internal class CardComparer_bySuit : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.suits > y.suits)
                return 1;
            if (x.suits < y.suits)
                return -1;
            else
                return 0;
        }
    }
}