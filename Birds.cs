using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Birds : Animal
    {
        protected Birds(string name, double weight, double wingSize) : base(name, weight)
        {
            this.WingSize = wingSize;
                
        }

        //  Bird – double WingSize

        public double WingSize { get; set; }

        public override string ToString()
        {
           
        
            return $"{GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";


           // Birds – "{AnimalType} [{AnimalName}, {WingSize}, {AnimalWeight}, {FoodEaten}]"




        }

    }
}
