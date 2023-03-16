using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Cat : Felime
    {
        public string breed { get; set; }

        public Cat(string _animalName, string _animalType, double _animalWeight, int _foodEaten, string _livingRegion) : base(_animalName, _animalType, _animalWeight, _foodEaten, _livingRegion)
        {
            breed = breed;
        }
        new public void makeSound()
        {
            Console.WriteLine("MMjauuuuu");
        }
        new public void eat(Food food)
        {
            _foodEaten = food.quantity;
        }
        public override string ToString()
        {
            return new string(_animalType + " [" + _animalName +", "+ breed +  ", " + _animalWeight + ", " + _livingRegion + ", " + _foodEaten + "]");
        }
    }
}
