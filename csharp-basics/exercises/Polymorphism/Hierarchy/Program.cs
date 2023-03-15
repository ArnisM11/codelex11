using System;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            string c1 = "Cat Gray 1.1 Home Persian";
            string[] arr = c1.Split(' ');
            //Console.WriteLine(arr[1]);
            Cat c2 = new Cat("Muris","Cat",1.1,2,"Riga");
            //Mammal m1 = new Mammal("Muris", "Zils", 2.2, 2, "Riga");
            Tiger t1 = new Tiger("Tiger", "Blue", 14.5, 4, "Sigulda");

            Console.WriteLine();
            


            Console.ReadKey();
        }
    }
}