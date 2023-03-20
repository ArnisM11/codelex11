namespace Exercise14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date();
            Console.WriteLine(date1.WeekdayInDutch(1970, 9,21));
            Console.WriteLine(date1.WeekdayInDutch(1945, 9, 2));
            Console.WriteLine(date1.WeekdayInDutch(2001, 9, 11));
            Console.ReadKey();
        }
    }
}