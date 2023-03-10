using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace ReplaceSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };
            List<string> list = words.ToList();
            list = list.Select(x => x.Replace("ea", "*")).ToList();
            foreach(var word in list)
            {
                Console.WriteLine(word);
            }
            Console.ReadKey();
        }
    }
}
