using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            int startKilometers;
            int liters;
            int endKilometers;
            
            Console.Write("Enter starting km => ");
            startKilometers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter starting liters => ");
            liters = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter end km => ");
            endKilometers = Convert.ToInt32(Console.ReadLine());

            Car car = new Car(startKilometers, endKilometers, liters);

            Console.WriteLine("Kilometers per liter are " + car.CalculateConsumption() + " gasHog:" + car.GasHog());
            //car.FillUp(endKilometers, 30);
            Console.WriteLine("Car consumption per 100km are : " + car.ConsumptionPer100Km() + " liters.");
            //Console.WriteLine("Car1 Kilometers per liter are " + car1.CalculateConsumption() + " economyCar:" + car.EconomyCar());
            Console.ReadKey();
        }
    }
}
