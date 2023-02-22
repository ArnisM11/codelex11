namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a text ===> ");
            string text = Console.ReadLine().ToString().ToLower();
            
            char inChar;

            for(int i = 0; i < text.Length; i++)
            {
                inChar = (char)text[i];
                switch (inChar)
                {
                    case 'a':case 'b':case 'c': 
                        Console.WriteLine(2); break;
                    case 'd':case 'e':case 'f':
                        Console.WriteLine(3); break;
                    case 'g':case 'h':case 'i':
                        Console.WriteLine(4); break;
                    case 'j':case 'k':case 'l':
                        Console.WriteLine(5); break;
                    case 'm':case 'n':case 'o':
                        Console.WriteLine(6); break;
                    case 'p':case 'q':case 'r':case 's':
                        Console.WriteLine(7); break;
                    case 't':case 'u': case 'v':
                        Console.WriteLine(8); break;
                    case 'w':case 'x':case 'y':case 'z':
                        Console.WriteLine(9); break;
                    default: Console.WriteLine(0); break;
                }
            }
            Console.ReadKey();
        }
    }
}