
using System;
using System.Collections.Generic;

namespace DaysNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var days = Enum.GetNames(typeof(DayOfWeek));
            foreach(var day in days)
            {
                Console.WriteLine(day);
            }

            Console.ReadKey();
        }
    }
}