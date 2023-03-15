using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Felime : Mammal
    {
        public Felime(string _animalName, string _animalType, double _animalWeight, int _foodEaten, string _livingRegion) : base(_animalName, _animalType, _animalWeight, _foodEaten,_livingRegion)
        {
            
        }

        new public void makeSound()
        {
            Console.WriteLine("Fellll");
        }
    }
}
