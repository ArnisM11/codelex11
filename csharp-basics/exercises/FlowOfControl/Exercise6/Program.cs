using System;

namespace GetTheCentury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Century(1756));
            Console.WriteLine(Century(1555));
            Console.WriteLine(Century(1000));
            Console.WriteLine(Century(1001));
            Console.WriteLine(Century(2005));
            Console.ReadKey();
        }

        static string Century(int year)
        {
            if (year >= 1000 && year < 2010)
            {
                if (year == 1000) return "10th century";
                else if (year >= 1001 && year <= 1100) return "11th century";
                else if (year >= 1101 && year <= 1200) return "12th century";
                else if (year >= 1201 && year <= 1300) return "13th century";
                else if (year >= 1301 && year <= 1400) return "14th century";
                else if (year >= 1401 && year <= 1500) return "15th century";
                else if (year >= 1501 && year <= 1600) return "16th century";
                else if (year >= 1601 && year <= 1700) return "17th century";
                else if (year >= 1701 && year <= 1800) return "18th century";
                else if (year >= 1801 && year <= 1900) return "19th century";
                else if (year >= 1901 && year <= 2000) return "20th century";
                else if (year >= 2001 && year <= 2010) return "21th century";
            }
            else return "error";
            return "not handled";
        }
    }
}
