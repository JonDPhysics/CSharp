using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Box some string data into a variable
            // object BoxedData = "This is clearly a string";
            // //Make sure it is the type you need before proceeding
            // if (BoxedData is int) {
            //     //This shouldn't run
            //     Console.WriteLine("I guess we have an integer value in this box?");
            // }
            // if (BoxedData is string) {
            //     Console.WriteLine("It is totally a string in the box!");
            // }
            // object ActuallyString = "a string";
            // string ExplicitString = ActuallyString as string;

            // // THIS WON'T WORK!!
            // object ActuallyInt = 256;
            // int ExplicitInt = ActuallyInt as int;
            List<object> ObjectOfMyEye = new List<object>();

            ObjectOfMyEye.Add(7);
            ObjectOfMyEye.Add(28);
            ObjectOfMyEye.Add(-1);
            ObjectOfMyEye.Add(true);
            ObjectOfMyEye.Add("chair");

            int sum = 0;

            for(int i = 0; i < ObjectOfMyEye.Count; i++)
            {
                if(ObjectOfMyEye[i] is int)
                {
                    int num = (int)ObjectOfMyEye[i];
                    Console.WriteLine(ObjectOfMyEye[i]);
                    sum = sum + (int)ObjectOfMyEye[i];
                }

                else if(ObjectOfMyEye[i] is string)
                {
                    // string String = (string)ObjectOfMyEye[i];
                    Console.WriteLine(ObjectOfMyEye[i]);
                }

                else if(ObjectOfMyEye[i] is bool)
                {
                    // bool Boolean = (bool)ObjectOfMyEye[i];
                    Console.WriteLine(ObjectOfMyEye[i]);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
