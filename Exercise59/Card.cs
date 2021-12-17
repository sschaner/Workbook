using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise59
{
    public class Card
    {
        private Suit suit;
        public Suit Suit
        {
            get { return suit; }
            set { suit = value; }
        }

        private Rank rank;
        public Rank Rank
        {
            get { return rank; }
            set { rank = value; }
        }
    }
}
