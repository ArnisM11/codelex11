using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Cat : Felime
    {
        public string Breed { get; set; }

        public Cat(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion) : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            Breed = Breed;
        }
        new public void makeSound()
        {
            Console.WriteLine("MMjauuuuu");
        }
        new public void eat(Food food)
        {
            FoodEaten = food.Quantity;
        }
        public override string ToString()
        {
            return new string(AnimalType + " [" + AnimalName +", "+ Breed +  ", " + AnimalWeight + ", " +  LivingRegion + ", " + FoodEaten + "]");
        }
    }
}
