// See https://aka.ms/new-console-template for more information


internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter minutes : ");
        var minutes = int.Parse(Console.ReadLine());
        var minutesInYear = 365 * 24 * 60;
        var minutesInDay = 24 * 60;

        var years = minutes / minutesInYear;
        var minutesToDays = minutes % minutesInYear;
        var days = minutesToDays / minutesInDay;

        Console.WriteLine("Its " + years + " and " + days + " days.");
        Console.ReadKey();
    }
}