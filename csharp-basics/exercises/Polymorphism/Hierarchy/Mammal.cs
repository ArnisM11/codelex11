using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Mammal : Animal
    {
        public string LivingRegion { get; set; }

        public Mammal(string animalName, string animalType, double animalWeight, int foodEaten,string livingRegion) : base(animalName,animalType,animalWeight,foodEaten)
        {
            this.LivingRegion = livingRegion;
            
        }
        public void MakeSound()
        {
            Console.WriteLine("MaMMM");
        }
       
    }
}
