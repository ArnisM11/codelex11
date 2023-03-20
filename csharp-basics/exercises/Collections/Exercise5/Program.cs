namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isHappy(91));
            Console.WriteLine(isHappy(4));
            Console.ReadKey();
        }

        public static string isHappy(int num)
        {
            while (num != 1 && num != 4)
            {
                int sum = 0;
                while (num > 0)
                {
                    int digit = num % 10;
                    sum += digit * digit;
                    num /= 10;
                }
                num = sum;
            }
            if (num == 1) return "Happy";
            else return "Not Happy";
        }
    }
}