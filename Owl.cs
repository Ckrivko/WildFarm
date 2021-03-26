using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Owl : Birds
    {
        private double increaseProcent = 0.25;

        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override void AskForFood(Food food)
        {
            Console.WriteLine("Hoot Hoot");

            if (food.FoodType == "Meat")
            {
                this.FoodEaten += food.Quantity;
                this.Weight += food.Quantity * this.increaseProcent;

            }
            else
            {
                Console.WriteLine($"{GetType().Name} does not eat {food.FoodType}!");

            }
        }
    }
}
