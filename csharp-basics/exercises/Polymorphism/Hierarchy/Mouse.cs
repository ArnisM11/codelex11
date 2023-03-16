using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, int foodEaten,string livingRegion) : base(animalName, animalType, animalWeight, foodEaten,livingRegion)
        {
            
        }
        new public void MakeSound()
        {
            Console.WriteLine("miumiu");
        }
        new public void eat(Food food)
        {
            if(food is Meat)
            {
                Console.WriteLine("Mouses are not eating that type of food! ");
            }
            else foodEaten = food.quantity;
        }
        public override string ToString()
        {
            return new string(animalType + " [" +animalName + ", " + animalWeight + ", " + livingRegion + ", " + foodEaten + "]");
        }
    }
}
