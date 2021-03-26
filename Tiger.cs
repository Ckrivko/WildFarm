using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Tiger : Feline
    {
        private double increaseProcent = 1.0;
        
        public Tiger(string name, double weight, string breed, string livingRegion) : base(name, weight, breed, livingRegion)
        {
            
        
        }              


        public override void AskForFood(Food food)
        {

            Console.WriteLine("ROAR!!!");

            if ( food.FoodType == "Meat")
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
