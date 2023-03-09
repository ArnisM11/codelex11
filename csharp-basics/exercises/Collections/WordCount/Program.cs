using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\i7-240\Source\Repos\Arrays\csharp-basics\exercises\Collections\WordCount\lear.txt", Encoding.UTF8);
            

            int words = 0;
            int lines = 1;
            int commas = 0;

            for(int i = 0;i< text.Length;i++)
            {
                if (text[i] == ' ' || text[i] == '\n' || text[i] == '\t' || text[i] == char.Parse("'")) words++;
                if (text[i] == '\n') lines++;
                if (text[i] == char.Parse("'") || text[i] == ',') commas++;
            }
            text.Trim();
            char[] chars1 = text.ToCharArray();
            Console.WriteLine(text);
            Console.WriteLine("Line = "+ lines);
            Console.WriteLine("Words = " +  words);
            Console.WriteLine("Chars = " + (chars1.Count()-commas));

            Console.ReadKey();
        }
    }
}
