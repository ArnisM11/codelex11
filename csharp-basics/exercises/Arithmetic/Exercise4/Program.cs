namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int sum = 1;
            int N = 10;
            for(int i = 1; i <= N; i++)
            {
                sum *= i;
            }
            Console.WriteLine("Sum is : " + sum);

            Console.ReadKey();
        }
    }
}