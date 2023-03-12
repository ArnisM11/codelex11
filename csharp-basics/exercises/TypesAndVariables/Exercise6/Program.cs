using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfDigits = 5;
            byte sum = 0;

            for (int i = 0; i < numOfDigits; i++)
            {
                Console.WriteLine("Enter single digit nr(" + (i + 1) + ")");
                sum += Convert.ToByte(Console.ReadLine());
            }
            Console.WriteLine("Sum of these digits is : " + sum);

            Console.ReadKey();
        }
    }
}