namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter number to check if it is odd or even. ====> ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CheckOddEven(n1));

            Console.ReadKey();
        }
        public static string CheckOddEven(int number)
        {
            if (number % 2 == 0) Console.WriteLine("Even Number");
            else Console.WriteLine("Odd number");
            return "bye!";
        }
    }
}