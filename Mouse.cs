using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mouse : Mammal
    {

        private double increaseProcent = 0.10;
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
       
        
        }

        public override void AskForFood(Food food)
        {

            Console.WriteLine("Squeak");

            if (food.FoodType == "Vegetable" || food.FoodType == "Fruit")
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
