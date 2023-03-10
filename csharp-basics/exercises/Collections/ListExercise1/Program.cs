using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("blue");
            list.Add("red");
            list.Add("yellow");
            list.Add("pink");
            list.Add("green");
            foreach (string color in list)
            {
                Console.WriteLine(color);
            }
            Console.ReadKey();
        }
    }
}
