using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; set; }

        public Mammal(string animalName, string animalType, double animalWeight, int foodEaten,string livingRegion) : base(animalName,animalType,animalWeight,foodEaten)
        {
            if (string.IsNullOrEmpty(livingRegion)) throw new InvalidRegionException();
            this.LivingRegion = livingRegion;
        }

    }
}
