namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string points = "";
            Console.Write("Enter word #1 ==> ");
            string word1 = Convert.ToString(Console.ReadLine());
            Console.Write("Enter word #2 ==> ");
            string word2 = Convert.ToString(Console.ReadLine());
            int numberOfPoints = 30 - word1.Length - word2.Length;
            for (int i = 0; i < numberOfPoints; i++)
            {
                points += ".";
            }
            Console.WriteLine(word1 + points + word2);
            Console.ReadKey();
        }
    }
}