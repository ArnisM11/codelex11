namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Moran(132));
            Console.WriteLine(Moran(133));
            Console.WriteLine(Moran(134));
            Console.ReadKey();

        }
        static string Moran(int number)
        {
            int x = number;          //number kopija
            int sumOfNr = 0;
            int m = 0;
            int isPrime = 0;
            int checkIfPrime = 0;
            while (number > 0)
            {
                m = number % 10;
                sumOfNr = sumOfNr + m;
                number = number / 10;
            }
           
            checkIfPrime = x/sumOfNr;
            
            for (int i= 1; i <= checkIfPrime;i++)
            {
                if(checkIfPrime % i == 0)
                {
                    isPrime++;
                }
            }
            
            if (isPrime == 2) return "M";
            else if (x%sumOfNr == 0) return "H";
            else return "Neither";

        }
    }
}