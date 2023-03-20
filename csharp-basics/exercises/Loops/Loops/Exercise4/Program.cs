using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            for(int i = 0;i < vowels.Length; i++)
            {
                Console.Write(vowels[i]);
            }
            Console.WriteLine();
            foreach(char vowel in vowels)
            {
                Console.Write(vowel);
            }
            Console.ReadKey();
        }
    }
}
