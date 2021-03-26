using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Feline : Mammal
    {
        public Feline(string name, double weight, string breed, string livingRegion) : base(name, weight, livingRegion)
        {

            this.Breed = breed;
           
        }
       

        public string Breed { get; set; }

        public override string ToString()
        {
            return $"{GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";

            //  Felines – "{AnimalType} [{AnimalName}, {Breed}, {AnimalWeight}, {AnimalLivingRegion}, {FoodEaten}]"



        }

    }
}
