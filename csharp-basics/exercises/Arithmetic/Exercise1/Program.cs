namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer nr1 ====> ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer nr2 ====> ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if(n1 ==15 || n2 == 15)
            {
                Console.WriteLine("true");
            }
            else if(n1+n2 == 15 || n1 - n2 ==15 || n2-n1 ==15)
            {
                Console.WriteLine("true");
            }
            else Console.WriteLine("false");

            Console.ReadKey();
        }
    }
}