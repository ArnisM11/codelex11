using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../../flights.txt";
        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            List<string> citiesFrom = new List<string>();
            List<string> citiesTo = new List<string>();
            foreach(var s in readText)
            {
                citiesFrom.Add(s.Split(new string[] { " -> " }, StringSplitOptions.None)[0]);
                citiesTo.Add(s.Split(new string[] { " -> " }, StringSplitOptions.None)[1]);
            }
            var allCities = citiesFrom.Concat(citiesTo).Distinct().ToList();
            string input = " ";
            string startCity = " ";
            string destination = " ";
            Console.WriteLine("What would you like to do : ");
            Console.WriteLine("To display list of the cities press 1 ");
            Console.WriteLine("To exit program press #");
            input = Convert.ToString(Console.ReadLine());
            if(input == "1") PrintCities(allCities);
            Console.WriteLine("Select your starting city");
            startCity = Convert.ToString(Console.ReadLine());
            do
            {
                if (destination == startCity) break;
                if(destination == " ") destination = startCity;
                Console.WriteLine("Select a city out of available cities ");
                for (int i = 0; i < citiesFrom.Count; i++)
                {
                    if (citiesFrom[i] == destination)
                    {
                        Console.WriteLine(citiesTo[i]);
                    }
                }
                destination = Convert.ToString(Console.ReadLine());
            } while (destination != "#" && input == "1" || startCity != destination || input != "#");
            if (startCity == destination) Console.WriteLine("You have reached your destination!");
            else if (input == "#") Console.WriteLine("You quitted!");
            Console.ReadKey();
        }
        public static void PrintCities(List<string> city)
        {
            foreach (var s in city)
            {
                Console.WriteLine(s);
            }
        }
    }
}
