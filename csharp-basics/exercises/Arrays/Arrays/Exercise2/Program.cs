using System;

namespace Exercise2
{
    class Program
    {       
        private static void Main(string[] args)
        {
            var sum = 0;
            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());
            for (int i = minNumber; i<=maxNumber; i++) {
                sum+= i;
            }
            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}
