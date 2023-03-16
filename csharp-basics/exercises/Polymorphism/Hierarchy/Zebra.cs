using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Zebra : Mammal 
    {
        public Zebra(string _animalName, string _animalType, double _animalWeight, int _foodEaten, string _livingRegion) : base(_animalName, _animalType, _animalWeight, _foodEaten, _livingRegion)
        {
           
        }
        new public void makeSound()
        {
            Console.WriteLine("Brrrrr");
        }
        new public void eat(Food food)
        {
            if (food is Meat)
            {
                Console.WriteLine("Zebras are not eating that type of food! ");
            }
            else _foodEaten = food.quantity;

        }
        public override string ToString()
        {
            return new string(_animalType + " [" + _animalName + ", " + _animalWeight + ", " + _livingRegion + ", " + _foodEaten + "]");
        }
    }
}
