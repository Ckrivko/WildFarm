using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Dog : Mammal
    {
        private double increaseProcent = 0.40;

        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void AskForFood(Food food)
        {
            Console.WriteLine("Woof!");

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
