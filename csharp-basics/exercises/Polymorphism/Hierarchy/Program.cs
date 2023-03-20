using System;
using System.ComponentModel.DataAnnotations;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            string t1 = "Tiger Typcho 167,7 Asia";
            string[] arr = t1.Split(' ');
            string type = arr[0];
            string food1 = "Vegetable 4";
            string[] foodArr = food1.Split(' ');
            Vegetable f1 = new Vegetable();
            Meat m1 = new Meat();

            if (foodArr[0] == "Vegetable")
            {
                f1 = new Vegetable(Convert.ToInt32(foodArr[1]));
            }
            else if(foodArr[0] == "Meat")
            {
                m1 = new Meat(Convert.ToInt32(foodArr[1]));
            }

            switch (type)
            {
                case "Zebra":
                    Zebra zeb = new Zebra(arr[1], arr[0], Convert.ToDouble(arr[2]),0, arr[3]);
                    zeb.makeSound();
                    zeb.eat(f1);
                    break;
                case "Tiger":
                    Tiger tig = new Tiger(arr[1], arr[0], Convert.ToDouble(arr[2]),0, arr[3]);
                    tig.makeSound();
                    tig.eat(f1);
                    break;
                case "Mouse":
                    Mouse mou = new Mouse(arr[1], arr[0], Convert.ToDouble(arr[2]),0, arr[3]);
                    mou.makeSound();
                    break;
                case "Cat":
                    Cat cat = new Cat(arr[1], arr[0], Convert.ToDouble(arr[2]),0, arr[3]);
                    cat.Breed = arr[5];
                    cat.makeSound();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}