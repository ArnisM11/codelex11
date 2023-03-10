using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        //private const string Path = (@"C:\\Users\\i7-240\\Source\\Repos\\Arrays\\csharp-basics\\exercises\\Collections\\Histogram\\midtermscores.txt", Encoding.UTF8);
        

        private static void Main(string[] args)
        {
            string readText = File.ReadAllText(@"../../midtermscores.txt", Encoding.UTF8);
            List<int> numbers = new List<int>(Array.ConvertAll(readText.Split(' '), int.Parse));
            int[] counts = Enumerable.Range(0, 11).Select(range =>
            numbers.Count(score => score / 10 == range)).ToArray();
            for(int i = 0; i < counts.Length-1; i++)
            {
                string range = String.Format("{0:D2} - {1:D2}:", i * 10, i * 10 + 9);
                string stars = new string('*', counts[i]);
                Console.WriteLine(range + " " + stars);
            }
            Console.WriteLine("    100: " + new String('*', counts[10]));
            Console.ReadKey();
        }
    }
}
