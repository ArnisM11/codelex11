using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Animal
    {
        public string _animalName { get; set; }
        public string _animalType { get; set; }
        public double _animalWeight { get; set; }
        public int _foodEaten { get; set; }


        public Animal()
        {
            _animalName= string.Empty;
            _animalType= string.Empty;
            _foodEaten= 0;
            _animalWeight = 0.0d;
        }
        public Animal(string animalName, string animalType, double animalWeight, int foodEaten)
        {
            _animalName = animalName;
            _animalType = animalType;
            _animalWeight = animalWeight;
            _foodEaten = foodEaten;
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
