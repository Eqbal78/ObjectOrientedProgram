using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgram.DeackOfCard
{
    class Card
    {
        public string suit;
        public string rank;
        public Card(string suit, string rank)
        {
            this.suit = suit;
            this.rank = rank;
        }
    }
}
