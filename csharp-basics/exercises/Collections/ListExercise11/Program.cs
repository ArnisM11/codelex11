using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>{ "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
            list.Insert(4, "x");
            list[list.Count-1] = "k";
            list.Sort();
            Console.WriteLine(list.Contains("Foobar"));
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();
        }
    }
}
