using System;

namespace DragRace
{
	public class Raf : ICar
	{
		private int _currentSpeed = 0;

		public void SpeedUp()
		{
			_currentSpeed += 2;
		}

		public void SlowDown()
		{
			_currentSpeed -= 5;
		}

		public string ShowCurrentSpeed()
		{
			return _currentSpeed.ToString();
		}

		public void StartEngine()
		{
			Console.WriteLine("grgrgrgrgrg");
		}
	}
}