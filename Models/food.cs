using System;

namespace hungryninja.Models
{
    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy; 
        public bool IsSweet; 
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string name, int cal, bool spicy, bool sweet)
        {
            this.Name = name;
            this.Calories = cal;
            this.IsSpicy = spicy;
            this.IsSweet = sweet;
        }
    }
}