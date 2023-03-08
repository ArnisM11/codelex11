namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fuelGauge = new FuelGauge();
            var odometer = new Odometer(fuelGauge);

            for(int i = 0; i < 30; i++)
            {
                fuelGauge.Fill();
            }

            Console.WriteLine(fuelGauge.ReportLevel() + " filled the tank!");

           
            while(fuelGauge.ReportLevel() > 0)
            {
                odometer.Drive();
                Console.WriteLine("Fuel => " + fuelGauge.ReportLevel());
                Console.WriteLine("Odometer => " + odometer.Report());
            }

            Console.WriteLine(fuelGauge.ReportLevel());

            Console.ReadKey();
        }
    }
}