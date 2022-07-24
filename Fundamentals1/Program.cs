using System;

namespace Fundamentals1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // for loop that prints all values from 1-255
            // for (int i = 1; i < 256; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // For loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            // for (int j = 1; j < 101; j++)
            // {
            //     if( j % 3 == 0 && j % 5 != 0 )
            //     {
            //         // Console.WriteLine(j);
            //         // change output to Fizz.
            //         Console.WriteLine("Fizz");
            //     }

            //     else if( j % 5 == 0 && j % 3 != 0 )
            //     {
            //         // Console.WriteLine(j);
            //         // change output to Buzz.
            //         Console.WriteLine("Buzz");
            //     }

            //     else if( j % 15 == 0 )
            //     {
            //         // Console.WriteLine(j);
            //         // change output to FizzBuzz.
            //         Console.WriteLine("FizzBuzz");
            //     }
            //     else
            //     {
            //         // I want to see the rest of the numbers.
            //         Console.WriteLine(j);
            //     }
            // }

            // While loop that prints all values from 1-255.
            // int count = 1;
            // while (count < 256)
            // {
            //     Console.WriteLine(count);
            //     count = count + 1;
            // }
            // While loop that prints all values from 1-100.
            // int num = 1;
            // while (num < 101)
            // {
            //     Console.WriteLine(num);
            //     num = num + 1;
            // }
            // While loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            int num = 1;
            while (num < 101)
            {
                if(num % 3 == 0 && num % 5 != 0)
                {
                    // Console.WriteLine(num);
                    // change output to Fizz.
                    Console.WriteLine("Fizz");
                    num++;
                }
                else if(num % 5 == 0 && num % 3 != 0)
                {
                    // Console.WriteLine(num);
                    // change output to Buzz.
                    Console.WriteLine("Buzz");
                    num++;
                }
                else if(num % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    num++;
                }
                else
                {
                    Console.WriteLine(num);
                    num++;
                }
            }
        }
    }
}
