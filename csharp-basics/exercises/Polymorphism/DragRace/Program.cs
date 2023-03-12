using System;
using System.Collections.Generic;
using System.Linq;


namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            var cars = new List<ICar>();
            cars.Add(new Audi());
            cars.Add(new Bmw());
            cars.Add(new Tesla());
            cars.Add(new Golf3());
            cars.Add(new Raf());
            cars.Add(new Lexus());

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    cars.ForEach(c => c.StartEngine());
                }

                else
                {
                    for (int j = 0; j < cars.Count; j++)
                    {
                        if (i == 2)
                        {
                            if (cars[j] is IBoostable boostable)
                            {
                                boostable.UseNitrousOxideEngine();
                            }

                            else
                            {
                                cars[j].SpeedUp();
                            }
                        }

                        else
                        {
                            cars[j].SpeedUp();
                        }
                    }
                }
            }
            var maxSpeed = cars.Max(c => int.Parse(c.ShowCurrentSpeed()));
            var car = cars.First(c => c.ShowCurrentSpeed() == maxSpeed.ToString());
            Console.WriteLine(car.GetType() + " max speed = " + maxSpeed);
            Console.ReadKey();
        }
    }
}