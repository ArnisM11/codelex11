using System.Drawing;

namespace Exercise8
{
    internal class AsciiFigure
    {
        static void Main(string[] args)
        {
            DrawFigure(5);
            Console.ReadKey();
        }
        static void DrawFigure(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < 2 * size - 2 * i - 2; j++)
                {
                    Console.Write("//");
                }
                for (int j = 0; j < 4 * i; j++)
                {
                    Console.Write("**");
                }
                for (int j = 0; j < 2 * size - 2 * i - 2; j++)
                {
                    Console.Write("\\\\");
                }
                Console.WriteLine();
            }
        }
    }
}

