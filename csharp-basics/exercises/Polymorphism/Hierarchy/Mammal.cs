using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Mammal : Animal
    {
        public string _livingRegion { get; set; }

        public Mammal(string _animalName, string _animalType, double _animalWeight, int _foodEaten,string livingRegion) : base(_animalName,_animalType,_animalWeight,_foodEaten)
        {
            this._livingRegion = livingRegion;
            
        }
        public void MakeSound()
        {
            Console.WriteLine("MaMMM");
        }
       
    }
}
