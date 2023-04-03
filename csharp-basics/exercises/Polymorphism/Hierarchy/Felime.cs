using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Felime : Mammal
    {
        /*public Felime()
        {
            AnimalName = string.Empty;
            AnimalType = string.Empty;
            FoodEaten = 0;
            AnimalWeight = 0.0d;
            LivingRegion = string.Empty;
        }*/
        public Felime(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion) : base(animalName, animalType, animalWeight, foodEaten,livingRegion)
        {
        }
    }
}
