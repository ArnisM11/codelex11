using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            float average;
            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number) 
            {
                sum += number;
            }
            average = (float)sum / (float)upperBound;

            Console.WriteLine("The sum of " + lowerBound+ " to "+ upperBound+ " is " + sum);
            Console.WriteLine("The average is " + average);
            Console.ReadLine();
        }
    }
}
