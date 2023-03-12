namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a string");
            string str = Console.ReadLine();
            int res = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                {
                    res++;
                }
            }
            Console.WriteLine("Your string has " + res + " capital letters!");

            Console.ReadKey();
        }
    }
}