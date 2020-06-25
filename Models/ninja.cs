using System;
using System.Collections.Generic;

namespace hungryninja.Models
{
    class Ninja
    {
        private int calorieIntake;
        public int calorieAmount
        {
            get
            {
                return calorieIntake;
            }
        }
        public bool IsFull {
            get {
                return calorieIntake >= 1200;
            }
        }
        public List<Food> FoodHistory;
        public Ninja(int cal)
        {
            this.calorieIntake = 0;
            //this.calorieAmount = cal;
            this.FoodHistory = new List<Food>() { };
        }
     
    // add a constructor
        public void Eat(Food item)
        {
            Console.WriteLine($"Ninja is about to eat {item.Name}");
            if (this.IsFull ==true)
            {
                Console.WriteLine("Ninja is full and can't eat anymore!");

            }
            else 
            {
                this.calorieIntake +=item.Calories;
                this.FoodHistory.Add(item);
                System.Console.WriteLine($"Food name: {item.Name} , Spicy: {item.IsSpicy}, Sweet: {item.IsSweet}. {this.calorieAmount} {this.calorieIntake} ");
            }
        }
    

     
    // add a public "getter" property called "IsFull"
     
    // build out the Eat method
    
    }
}
