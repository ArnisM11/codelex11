namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input distance in meters ===> ");
            int distMeters = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input hours ===> ");
            int timeH = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input minutes ===> ");
            int timeM = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input seconds ===> ");
            int timeS = Convert.ToInt32(Console.ReadLine());


            int totalTimeInSeconds = timeH * 3600 + timeM * 60 + timeS;
            float totalTimeInHours = (float)totalTimeInSeconds / 3600;


            float speedMS = (float)distMeters / (float)totalTimeInSeconds;
            double speedKmH = (double)distMeters / (double)totalTimeInHours / 1000;
            double speedMH = (double)distMeters / (double)totalTimeInHours / 1609;


            Console.WriteLine("Your speed in meters/second is " + speedMS);
            Console.WriteLine("Your speed in km/h is " + speedKmH.ToString("F8"));
            Console.WriteLine("Your speed in miles/h is " + speedMH.ToString("F8"));


            Console.ReadKey();
        }
    }
}