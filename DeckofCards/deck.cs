using System;
using System.Collections.Generic;

namespace DeckofCards
{

    class Deck
    {
        public List<Card> Cards;
        public static List<Card> Shuffle(List<Card> list)
        {
            Random rand = new Random();
            for (int i = list.Count-1; i >= 1; i--)
            {
                int j = rand.Next(0, i+1);
                Card temp = list[j];
                list[j] = list[i];
                list[i] = temp;
            }
            return list;
        }
        public Deck()
        {
            Cards = new List<Card>();
            string[] suits = {"Hearts", "Diamond", "Clubs", "Spades"};
            string[] stringVal = {"2","3","4","5","6", "7","8","9","10","J","Q","K","A"};
            int value = 1;
            foreach (string suit in suits)
            {
                foreach (string val in stringVal)
                {
                    value++;
                    Cards.Add(new Card(suit, val, value));
                    Console.WriteLine($"This is the {val} of {suit} with value of {value}");
                }
                value = 1;
            }
            Cards = Shuffle(Cards);
            //Console.WriteLine($"This is the {val} of {suit} with value of {value}");
        }
    }
}
