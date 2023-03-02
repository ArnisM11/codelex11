namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] numbers = new int[20];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(100);
            }
            Console.WriteLine("Enter number 1 - 20 ==> ");
            int position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You picked nr " + position + " with value of " + numbers[position - 1]);
            Console.ReadKey();
        }
    }
}