using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; set; }

        /*public Mammal()
        {
            AnimalName = string.Empty;
            AnimalType = string.Empty;
            FoodEaten = 0;
            AnimalWeight = 0.0d;
            LivingRegion = string.Empty;
        }*/
        public Mammal(string animalName, string animalType, double animalWeight, int foodEaten,string livingRegion) : base(animalName,animalType,animalWeight,foodEaten)
        {
            this.LivingRegion = livingRegion;
        }

    }
}
