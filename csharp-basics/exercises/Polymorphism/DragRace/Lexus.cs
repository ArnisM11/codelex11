using System;

namespace DragRace
{
    public class Lexus : ICar, IBoostable
    {
        private int currentSpeed = 0;

        public void SpeedUp() 
        {
            currentSpeed += 9;
        }

        public void SlowDown() 
        {
            currentSpeed -= 9;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine() 
        {
            currentSpeed += 10;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}