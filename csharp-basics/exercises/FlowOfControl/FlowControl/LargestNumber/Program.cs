using System;

namespace LargestNumber
{
    class Program
    {
        //TODO: Write a C# program to to find the largest of three numbers.
        static void Main(string[] args)
        {
            var largest = 0;
            Console.WriteLine("Input the 1st number: ");
            var input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            var input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            var input3 = Convert.ToInt32(Console.ReadLine());

            if (input1 > input2)
            {
                if (input1 > input3) largest = input1;
                else largest = input2;
            }
            else if (input1 < input2)
            {
                if (input2 > input3) largest = input2;
                else largest = input3;
            }
            else largest = input3;
            
            Console.WriteLine("Largest number of these three : " +largest);

            Console.ReadLine();
        }
    }
}
