using System;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(GreaterThanY(new int[] {1,3,5,7}, new int 3));
        }

        public static void PrintNumber()
        {
            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintOdds()
        {
            for(int i = 1; i < 256; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintSum()
        {
            int sum = 0;
            for(int i = 0; i < 256; i++)
            {
                Console.WriteLine(i);
                sum += i;
                Console.WriteLine(sum);
            }
        }

        public static void LoopArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        public static void GetAverage(int[] numbers)
        {
            int avg = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                avg += numbers[i];
            }
            avg /= numbers.Length;
            Console.Write(avg);
        }

        public static int[] OddArray()
        {
            int[] odd = new int[255];
            for (int i = 1; i < 256; i+=2)
            {
                odd = new int[] {i};
            }
            return odd;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(y > numbers[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
