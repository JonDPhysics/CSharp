using System;
using System.Collections.Generic;

namespace DeckofCards
{
    class Card
    {
        public string StringVal;
        public string Suit;
        public int Val;
        public Card(string stringVal, string suit, int val) 
        {
            StringVal = stringVal;
            Suit = suit;
            Val = val;
        }
    }
}
