using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, int foodEaten,string livingRegion) : base(animalName, animalType, animalWeight, foodEaten,livingRegion)
        {
            //if (string.IsNullOrEmpty(animalName)) throw new InvalidNameException();
            //if (foodEaten < 0) throw new InvalidFoodException();
            //if (animalWeight <= 0) throw new InvalidWeightException();
            //if (string.IsNullOrEmpty(livingRegion)) throw new InvalidRegionException();
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
            else FoodEaten += food.Quantity;
        }
        public override string ToString()
        {
            return new string(AnimalType + " [" +AnimalName + ", " + AnimalWeight + ", " + LivingRegion + ", " + FoodEaten + "]");
        }
    }
}
