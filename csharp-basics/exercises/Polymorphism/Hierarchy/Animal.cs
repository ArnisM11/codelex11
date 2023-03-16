using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Animal
    {
        public string animalName { get; set; }
        public string animalType { get; set; }
        public double animalWeight { get; set; }
        public int foodEaten { get; set; }


        public Animal()
        {
            animalName= string.Empty;
            animalType= string.Empty;
            foodEaten= 0;
            animalWeight = 0.0d;
        }
        public Animal(string _animalName, string _animalType, double _animalWeight, int _foodEaten)
        {
            animalName = _animalName;
            animalType = _animalType;
            animalWeight = _animalWeight;
            foodEaten = _foodEaten;
        }

        public void makeSound()
        {
            Console.WriteLine("MUrrrrr");
        }

        public void eat(Food food)
        {

        }
    }
}
