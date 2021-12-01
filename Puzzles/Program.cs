using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        public static int[] RandomArray()
        {
            List<int> rndList = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                rndList.Add(rnd.Next(5,26));
            }
            int[] rndArr = rndList.ToArray();
            Console.WriteLine("[{0}]", string.Join(", ", rndArr));
            int min = rndArr[0];
            int max = rndArr[0];
            int sum = 0;
            for (int i = 0; i < rndArr.Length; i++)
            {
                sum += rndArr[i];
                if (rndArr[i] < min)
                {
                    min = rndArr[i];
                }
                if (rndArr[i] > max)
                {
                    max = rndArr[i];
                }
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(sum);
            return rndArr;
        }
        public static string TossCoin()
        {
            Console.WriteLine("Tossing a Coin!");
            List<string> coin = new List<string>()
            {
                "Heads", "Tails"
            };
            Random rnd = new Random();
            return coin[rnd.Next(2)];
        }

        public static double TossMultipleCoins(int num)
        {
            double count = 0;
            for(int i = 1; i < num; i++)
            {
                TossCoin();
                if (TossCoin() == "Heads")
                {
                    count++;
                }
            }
            double ratio = count/num;
            return ratio;
        }

        public static List<string> Shuffle(List<string> list)
        {
            Random rand = new Random();
            for (int i = list.Count-1; i >= 1; i--)
            {
                int j = rand.Next(0, i+1);
                string temp = list[j];
                list[j] = list[i];
                list[i] = temp;
            }
            return list;
        }
        public static List<string> Names()
        {
            List<string> names5 = new List<string>();
            List<string> names = new List<string>()
            {
                "Todd",
                "Tiffany",
                "Charlie",
                "Geneva",
                "Sydney"
            };
            names = Shuffle(names);
            for (int k = 0; k < names.Count; k++)
            {
                Console.WriteLine(names[k]);
                if (names[k].Length > 5)
                {
                    names5.Add(names[k]);
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", names5));
            return names5;
        }
        static void Main(string[] args)
        {
            // Random rnd = new Random();
            // RandomArray();
            // Console.WriteLine(TossCoin());
            // Console.WriteLine(TossMultipleCoins(rnd.Next(201)));
            Names();
        }
    }
}
