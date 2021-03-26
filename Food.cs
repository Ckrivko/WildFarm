using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public  class Food
    {
       
        
        public Food(string foodType, int quantity)
        {

            this.Quantity = quantity;

            this.FoodType = foodType;

        }

        public int Quantity { get; set; }

        public string FoodType { get; set; }
        

        //Vegetable;
        //Fruit;
        //Meat;
        //Seeds;

    }
}

