using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Cat : Feline
    {

        private double increaseProcent = 0.30;


        public Cat(string name, double weight, string breed, string livingRegion) : base(name, weight, breed, livingRegion)
        {

        }

        public override void AskForFood(Food food)
        {
            Console.WriteLine("Meow");

            if (food.FoodType == "Vegetable" || food.FoodType == "Meat")
            {
                this.FoodEaten += food.Quantity;
                this.Weight += food.Quantity * this.increaseProcent;

            }
            else
            {
                Console.WriteLine($"{GetType().Name} does not eat {food.FoodType}!");

            }
        }

        // Cats eat vegetables and meat;


    }
}
