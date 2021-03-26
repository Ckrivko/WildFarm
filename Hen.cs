using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Hen : Birds
    {
        private double increaseProcent = 0.35;

        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {

        }


        public override void AskForFood(Food food)
        {
            Console.WriteLine("Cluck");

            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * this.increaseProcent;


        }


    }
}
