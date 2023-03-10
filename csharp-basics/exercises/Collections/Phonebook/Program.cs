using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory pd1 = new PhoneDirectory();
            SortedDictionary sd = new SortedDictionary();
            sd.PutNumber("Janis", "22222222");
            pd1.PutNumber("Janis", "33333333");
            Console.WriteLine(sd.GetNumber("Janis"));
            Console.WriteLine(pd1.GetNumber("Janis"));
            Console.ReadKey();
        }
    }
}
