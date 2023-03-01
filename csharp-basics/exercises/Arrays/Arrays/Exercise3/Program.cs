using System;

namespace Exercise3
{
    class Program
    {
        //TODO: Write a C# program to calculate the average value of array elements.
        private static void Main(string[] args)
        {
            int[] numbers = {20, 30, 25, 35, -16, 60, -100};
            int sum = 0;
            for (int i = 0;i<numbers.Length;i++){
                sum += numbers[i];
            }
            double average = (double)sum / (double)numbers.Length;
            Console.WriteLine("Average sum of the array elements is : " + sum);
            Console.WriteLine("Average value of the array elements is : " + average);
            Console.ReadKey();
        }
    }
}
