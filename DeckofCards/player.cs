using System;
using System.Collections.Generic;

namespace DeckofCards
{
    class Player
    {
        public string Name;
        public List<Card> Hand;
        public Player(string name)
        {
            this.Name = name;
            Hand = new List<Card>();
        }
        public Card Draw(Deck deck)
        {
            Card Card = deck.Deal(deck.Cards);
            Hand.Add(Card);
            return Card;
        }
        public Card Discard(int index)
        {
            Card Card;
            if(index <Hand.Count)
            {
                Card = Hand[index];
                Hand.RemoveAt(index);
                return Card;
            }
            else
            {
                return null;
            }
        }
    }
}