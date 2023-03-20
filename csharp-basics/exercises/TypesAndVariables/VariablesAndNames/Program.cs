using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars, drivers, passengers, carsNotDriven, carsDriven, seatsInACar;
            double carpoolCapacity, averagePassengersPerCar;

            cars = 100;
            seatsInACar = 4.0;
            drivers = 28;
            passengers = 90;
            carsNotDriven = cars - (cars / drivers);
            carsDriven = cars / drivers;
            carpoolCapacity = carsNotDriven * seatsInACar;
            averagePassengersPerCar = (double)passengers / (double)drivers;

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + carpoolCapacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + averagePassengersPerCar.ToString("N2") + " in each car.");
            Console.ReadKey();
        }
    }
}