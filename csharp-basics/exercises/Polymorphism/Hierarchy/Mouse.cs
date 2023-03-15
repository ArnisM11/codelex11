using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Mouse : Mammal
    {
        public Mouse(string _animalName, string _animalType, double _animalWeight, int _foodEaten,string _livingRegion) : base(_animalName, _animalType, _animalWeight, _foodEaten,_livingRegion)
        {
            
        }
        new public void MakeSound()
        {
            Console.WriteLine("miumiu");
        }
        new public void eat(Food food)
        {
            if(food is Meat)
            {
                Console.WriteLine("Mouses are not eating that type of food! ");
            }
        }
    }
}
