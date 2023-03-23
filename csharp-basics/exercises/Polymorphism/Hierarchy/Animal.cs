using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Animal
    {
        public string AnimalName { get; set; }
        public string AnimalType { get; set; }
        public double AnimalWeight { get; set; }
        public int FoodEaten { get; set; }


        public Animal()
        {
            AnimalName= string.Empty;
            AnimalType= string.Empty;
            FoodEaten= 0;
            AnimalWeight = 0.0d;
        }
        public Animal(string _animalName, string _animalType, double _animalWeight, int _foodEaten)
        {
            AnimalName = _animalName;
            AnimalType = _animalType;
            AnimalWeight = _animalWeight;
            FoodEaten = _foodEaten;
        }

        public abstract void MakeSound();
        public abstract void Eat(Food food);

    }
}
