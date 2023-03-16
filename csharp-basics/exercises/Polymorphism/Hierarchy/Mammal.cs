using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Mammal : Animal
    {
        public string livingRegion { get; set; }

        public Mammal(string animalName, string animalType, double animalWeight, int foodEaten,string livingRegion) : base(animalName,animalType,animalWeight,foodEaten)
        {
            this.livingRegion = livingRegion;
            
        }
        public void MakeSound()
        {
            Console.WriteLine("MaMMM");
        }
       
    }
}
