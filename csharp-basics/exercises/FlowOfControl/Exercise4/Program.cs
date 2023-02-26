namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number 0-6. ---> ");
            int input = Convert.ToInt32(Console.ReadLine());
            PrintDayInWordSwitch(input);
            PrintDayInWord(input);
            Console.ReadKey();
        }

        static void PrintDayInWordSwitch(int day)
        {
            switch (day)
            {
                case 0:
                        Console.WriteLine("Sunday");
                        break;
                case 1:
                        Console.WriteLine("Monday");
                        break;
                case 2:
                        Console.WriteLine("Tuesday");
                        break;
                case 3:
                        Console.WriteLine("Wednesday");
                        break;
                case 4:
                        Console.WriteLine("Thursday");
                        break;
                case 5:
                        Console.WriteLine("Friday");
                        break;
                case 6:
                        Console.WriteLine("Saturday");
                        break;
                default:
                        Console.WriteLine("Not a valid day.");
                        break;
            }
        }
        
        static void PrintDayInWord(int day)
        {
            if (day == 0) Console.WriteLine("Sunday");
            else if (day == 1) Console.WriteLine("Monday");
            else if (day == 2) Console.WriteLine("Tuesday");
            else if (day == 3) Console.WriteLine("Wednesday");
            else if (day == 4) Console.WriteLine("Thursday");
            else if (day == 5) Console.WriteLine("Friday");
            else if (day == 6) Console.WriteLine("Saturday");
            else Console.WriteLine("Not a valid day");
        }
    }
}