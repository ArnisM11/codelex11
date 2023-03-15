using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Cat : Felime
    {
        private string breed { get; set; }

        public Cat(string _animalName, string _animalType, double _animalWeight, int _foodEaten, string _livingRegion) : base(_animalName, _animalType, _animalWeight, _foodEaten, _livingRegion)
        {
            this.breed = breed;
        }
        new public void makeSound()
        {
            Console.WriteLine("MMjauuuuu");
        }
        new public void eat(Food food)
        {
           
        }
    }
}
