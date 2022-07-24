using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Food
        {
            public string Name;
            public int Calories;
            // Foods can be Spicy and/or Sweet
            public bool IsSpicy; 
            public bool IsSweet; 
            // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
            public Food(string n, int c, bool isp, bool isw)
            {
                Name = n;
                Calories = c;
                IsSpicy = isp;
                IsSweet = isw;
            }
        }

    class Buffet
    {
        public List<Food> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Banana", 50, false, true),
                new Food("Jalopeno", 15, true, false),
                new Food("Fish Tacos", 350, true, true),
                new Food("Poke", 550, true, true),
                new Food("Sushi", 250, true, true),
                new Food("Rice", 150, false, false),
                new Food("Butter Noodles", 450, false, false)
            };
        }

        public Food Serve()
        {
            Random rnd = new Random();
            return Menu[rnd.Next(0, Menu.Count)];
        }
    }

    class Ninja
    {
        private int calorieIntake; 
        public List<Food> FoodHistory;

        // add a contructor

        // add a public "getter" property called "IsFull"

        // build out the Eat method
        public void Eat(Food item)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Buffet.Serve());
        }
    }
}
