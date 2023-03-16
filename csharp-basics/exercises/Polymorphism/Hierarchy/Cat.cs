using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Cat : Felime
    {
        public string breed { get; set; }

        public Cat(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion) : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            breed = breed;
        }
        new public void makeSound()
        {
            Console.WriteLine("MMjauuuuu");
        }
        new public void eat(Food food)
        {
            foodEaten = food.quantity;
        }
        public override string ToString()
        {
            return new string(animalType + " [" + animalName +", "+ breed +  ", " + animalWeight + ", " +  livingRegion + ", " + foodEaten + "]");
        }
    }
}
