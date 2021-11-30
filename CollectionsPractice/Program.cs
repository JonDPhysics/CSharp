using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Three Basic Arrays
            int[] arrayI = new int[10];
            string[] arrayS = new string[] {"Tim", "Martin", "Nikki", "Sara"};
            bool[] arrayB = new bool[] {true, false, true, false, true, false, true, false, true, false};

            // List of Flavors
            List<string> icecream = new List<string>();
            icecream.Add("chocolate");
            icecream.Add("vanilla");
            icecream.Add("cookies and cream");
            icecream.Add("strawberry");
            icecream.Add("huckleberry");
            Console.WriteLine(icecream.Count);
            Console.WriteLine(icecream[2]);
            icecream.RemoveAt(2);
            Console.WriteLine(icecream.Count);

            // User Info Dictionary
            Dictionary<string,string> nameFlavor = new Dictionary<string, string>();
            Random rnd = new Random();
            nameFlavor.Add(arrayS[0], icecream[rnd.Next(icecream.Count)]);
            nameFlavor.Add(arrayS[1], icecream[rnd.Next(icecream.Count)]);
            nameFlavor.Add(arrayS[2], icecream[rnd.Next(icecream.Count)]);
            nameFlavor.Add(arrayS[3], icecream[rnd.Next(icecream.Count)]);
            foreach (var entry in nameFlavor)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
        }
    }
}
