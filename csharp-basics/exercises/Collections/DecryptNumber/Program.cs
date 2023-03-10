using System;
using System.Collections.Generic;

namespace DecryptNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cryptedNumbers = new List<string>             
            {
                "())(",
                "*$(#&",
                "!!!!!!!!!!",
                "$*^&@!",
                "!)(^&(#@",
                "!)(#&%(*@#%"
            };
            foreach (string s in cryptedNumbers)
            {
                string decryptedString = "";
                foreach (char c in s)
                {
                    if (c == '!')
                    {
                        decryptedString += '1';
                    }
                    else if (c == '@')
                    {
                        decryptedString += '2';
                    }
                    else if (c == '#')
                    {
                        decryptedString += '3';
                    }
                    else if (c == '$')
                    {
                        decryptedString += '4';
                    }
                    else if (c == '%')
                    {
                        decryptedString += '5';
                    }
                    else if (c == '^')
                    {
                        decryptedString += '6';
                    }
                    else if (c == '&')
                    {
                        decryptedString += '7';
                    }
                    else if (c == '*')
                    {
                        decryptedString += '8';
                    }
                    else if (c == '(')
                    {
                        decryptedString += '9';
                    }
                    else if (c == ')')
                    {
                        decryptedString += '0';
                    }
                    else
                    {
                        decryptedString += c;
                    }
                }
                Console.WriteLine(decryptedString);
            }
            Console.ReadKey();
        }
    }
}
