using System;
using System.Collections.Generic;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                var input = Console.ReadLine();
                var input2 = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }



                string[] line = input.Split();
                string[] line2 = input2.Split();
 

                Animal animal = CreateAnimal(line);
                Food food = new Food(line2[0], int.Parse(line2[1]));

                animal.AskForFood(food);
                animals.Add(animal);
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        
        }

        public static Animal CreateAnimal(string[] line)
        {
            Animal animal = null;

            string animalType = line[0]; // вид
            string name = line[1];       //име
            double weight = double.Parse(line[2]);    //тегло

            if (animalType == nameof(Cat))
            {
                string livingRegion = line[3];
                string breed = line[4];

                animal = new Cat(name, weight, breed, livingRegion);
            }

            else if (animalType == nameof(Tiger))
            {
                string livingRegion = line[3];
                string breed = line[4];

                animal = new Tiger(name, weight, breed, livingRegion);

            }

            else if (animalType == nameof(Dog))
            {
                string livingRegion = line[3];
                animal = new Dog(name, weight, livingRegion);
            }

            else if (animalType == nameof(Mouse))
            {
                string livingRegion = line[3];
                animal = new Mouse(name, weight, livingRegion);
            }

            else if (animalType == nameof(Hen))
            {
                double wingSize = double.Parse(line[3]);
                animal = new Hen(name, weight, wingSize);
            }

            else if (animalType == nameof(Owl))
            {
                double wingSize = double.Parse(line[3]);
                animal = new Owl(name, weight, wingSize);
            }

            // protected Cat(string name, double weight, string breed, string livingRegion)
            // Felines - "{Type} {Name} {Weight} {LivingRegion} {Breed}";

            return animal;
        }



    }
}
