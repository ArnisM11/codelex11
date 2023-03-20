namespace Exercise10
{
    internal class NumberSquare
    {
        static void Main(string[] args)
        {
            int min;
            int max;
            Console.WriteLine("Min? ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max? ");
            max = Convert.ToInt32(Console.ReadLine());

            for (int i = min; i <= max; i++)
            {
                for (int j = i; j <= max; j++)
                {
                    Console.Write(j);
                }

                for (int k = min; k < i; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}