    using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            List<string> list1 = array.ToList();
            foreach(string auto in list1)
            {
                Console.WriteLine(auto);
            }

            Console.WriteLine();
            HashSet<string> set = new HashSet<string>(array);
            foreach (var auto in set)
            {
                Console.WriteLine(auto);
            }

            Console.WriteLine();
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"Audi", "Germany"},
                {"BMW", "Germany"},
                {"Honda", "Germany"},
                {"Mercedes", "Germany"},
                {"VolksWagen", "Germany"},
                {"Tesla", "USA"}
            };
            foreach (var auto in dict) 
            {
                Console.WriteLine($"{auto.Key} -> {auto.Value}");
            }

            Console.ReadKey();
        }
    }
}
