using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Tiger : Felime
    {
        new public string livingRegion { get; set; }

        public Tiger(string _animalName, string _animalType, double _animalWeight, int _foodEaten, string _livingRegion) : base(_animalName, _animalType, _animalWeight, _foodEaten, _livingRegion)
        {
            
        }
        new public void makeSound()
        {
            Console.WriteLine("RAAAWRRRR");
        }
        new public void eat(Food food)
        {
            if (food is Vegetable)
            {
                Console.WriteLine("Tigers are not eating that type of food! ");
            }
            else FoodEaten = food.Quantity;
        }
        public override string ToString()
        {
            return new string(AnimalType +" ["+ AnimalName+ ", "+AnimalWeight+ ", "+ livingRegion+", "+  FoodEaten + "]");
        }
    }
}
