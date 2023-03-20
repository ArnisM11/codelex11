using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var values = new List<string> { "Hi", "Meow", "Hello", "Meow", "Hi!", "Meow", "Hi", "Bye" };
            values = values.Where(value1 => values.Count(value2 => value1 == value2)==1).ToList();
            foreach(var value in values)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
    }
}
