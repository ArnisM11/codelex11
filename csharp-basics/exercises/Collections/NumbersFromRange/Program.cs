using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersFromRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var numbers = new List<int>();
            while (numbers.Count() < 10)
            {
                numbers.Add(random.Next(1, 100));
            }
            numbers = numbers.Where(x => x > 30 && x < 100).ToList();
            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
