using System;

namespace DragRace
{
    public class Bmw :ICar
    {
        private int _currentSpeed = 0;

        public void SpeedUp() 
        {
            _currentSpeed += 8;
        }

        public void SlowDown() 
        {
            _currentSpeed -= 8;
        }

        public string ShowCurrentSpeed() 
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}