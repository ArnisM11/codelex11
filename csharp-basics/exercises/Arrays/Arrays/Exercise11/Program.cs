namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindNemo("I am finding Nemo !"));
            Console.WriteLine(FindNemo("Nemo is me"));
            Console.WriteLine(FindNemo("I Nemo am"));
            Console.WriteLine(FindNemo("I nemo am"));
            Console.ReadKey();
        }

        static string FindNemo(string str)
        {
            string result = "I can`t found Nemo! :(";
            string[] arrayOfWords = str.Split(' ');
            for(int i = 0;i<arrayOfWords.Length;i++)
            {
                if (arrayOfWords[i] == "Nemo")
                {
                    result = "I found Nemo at " + ((int)i+1);
                }
            }
            return result;
        }
    }
}