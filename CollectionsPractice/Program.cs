using System;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Three Basic Arrays
            int arrayI = new int[10];
            string arrayS = new string[] {"Tim", "Martin", "Nikki", "Sara"};
            bool[] arrayB = new bool[] {true, false, true, false, true, false, true, false, true, false};

            // List of Flavors
            List<string> icecream = new List<string>("chocolate", "vanilla", "cookies and cream", "strawberry", "huckleberry");
            Console.WriteLine(icecream.Length);
            Console.WriteLine(icecream[2]);
            icecream.Remove[2];
            Console.WriteLine(icecream.Length);

            // User Info Dictionary
            Dictionary<string,string> nameFlavor = new Dictionary<string, string>();
            
        }
    }
}
