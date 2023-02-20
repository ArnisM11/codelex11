namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Im thinking of a number between 1 - 100. Try to guess it.");
            int guess = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int randomNr = rnd.Next(1, 100);
            if (guess == randomNr)
            {
                Console.WriteLine("You guessed it? What are the odds?!?");
            }
            else if (guess > randomNr)
            {
                Console.WriteLine("Sorry, you are too high.I was thinking of " + randomNr);
            }
            else if (guess < randomNr)
            {
                Console.WriteLine("Sorry, you are too low.I was thinking of " + randomNr);
            }
            else Console.WriteLine("Unhandled");

            Console.ReadKey();
        }
    }
}