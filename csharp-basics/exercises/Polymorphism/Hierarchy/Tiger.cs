using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Tiger : Felime
    {
        public string livingRegion { get; set; }

        /*public Tiger()
        {
            AnimalName = string.Empty;
            AnimalType = string.Empty;
            FoodEaten = 0;
            AnimalWeight = 0.0d;
            LivingRegion = string.Empty;
        }*/
        public Tiger(string _animalName, string _animalType, double _animalWeight, int _foodEaten, string _livingRegion) : base(_animalName, _animalType, _animalWeight, _foodEaten, _livingRegion)
        {
            if (_animalWeight <= 0)
            {
                throw new InvalidWeightException();
            }

            if (_animalType != "Tiger")
            {
                throw new InvalidTypeException();
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine("RAAAWRRRR");
        }
        public override void Eat(Food food)
        {
            if (food is Vegetable)
            {
                Console.WriteLine("Tigers are not eating that type of food! ");
            }
            else FoodEaten += food.Quantity;
        }
        public override string ToString()
        {
            return new string(AnimalType +" ["+ AnimalName+ ", "+AnimalWeight+ ", "+ livingRegion+", "+  FoodEaten + "]");
        }
    }
}
