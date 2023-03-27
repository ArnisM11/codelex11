using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Zebra : Mammal 
    {
        public Zebra(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion) : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
           
        }
        public override void MakeSound()
        {
            Console.WriteLine("Brrrrr");
        }
        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                Console.WriteLine("Zebras are not eating that type of food! ");
            }
            else FoodEaten = food.Quantity;

        }
        public override string ToString()
        {
            return new string(AnimalType + " [" + AnimalName + ", " + AnimalWeight + ", " + LivingRegion + ", " + FoodEaten + "]");
        }
    }
}
