using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            int n;
            int sum = 1;
            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < n; j++)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
