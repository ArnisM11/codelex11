// See https://aka.ms/new-console-template for more information
//ToDo: Write a query that returns names of days
//https://docs.microsoft.com/en-us/dotnet/api/system.dayofweek?view=net-6.0

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