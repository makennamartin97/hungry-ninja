using System;
using System.Collections.Generic;

namespace hungryninja.Models
{
    class Buffet
    {
        public List<Food> Menu;
        public static Random rand = new Random();
     
    //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Sushi", 200, true, false),
                new Food("Burger", 1000, false, false),
                new Food("Ben & Jerry's Half Baked Ice Cream", 1000, false, true),
                new Food("Chicken Enchiladas", 500, true, false),
                new Food("Loaded Nachos w/ queso, salsa, guac", 800, true, false),
                new Food("Cajun King Crab Legs", 400, true, false),
                new Food("Fudge Sundae", 800, false, true),

            };
        }
     
        public Food Serve()
        {
            return Menu[rand.Next(Menu.Count)];
        }
    }
}
