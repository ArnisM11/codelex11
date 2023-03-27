using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, int foodEaten,string livingRegion) : base(animalName, animalType, animalWeight, foodEaten,livingRegion)
        {
            
        }
        public override void MakeSound()
        {
            Console.WriteLine("miumiu");
        }
        public override void Eat(Food food)
        {
            if(food is Meat)
            {
                Console.WriteLine("Mouses are not eating that type of food! ");
            }
            FoodEaten += food.Quantity;
        }
        public override string ToString()
        {
            return new string(AnimalType + " [" +AnimalName + ", " + AnimalWeight + ", " + LivingRegion + ", " + FoodEaten + "]");
        }
    }
}
