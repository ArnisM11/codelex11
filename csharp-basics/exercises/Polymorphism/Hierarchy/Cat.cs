﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Cat : Felime
    {
        public string Breed { get; set; }

        public Cat(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion) : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            Breed = Breed;
        }
        public override void MakeSound()
        {
            Console.WriteLine("MMjauuuuu");
        }
        public override void Eat(Food food)
        {
            if (food.Quantity <= 0)
            {
                throw new InvalidFoodException();
            }
            else FoodEaten += food.Quantity;
        }
        public override string ToString()
        {
            return new string(AnimalType + " [" + AnimalName +", "+ Breed +  ", " + AnimalWeight + ", " +  LivingRegion + ", " + FoodEaten + "]");
        }
    }
}