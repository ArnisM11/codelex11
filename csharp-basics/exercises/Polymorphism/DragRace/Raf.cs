using System;

namespace DragRace
{
	public class Raf : ICar
	{
		private int currentSpeed = 0;

		public void SpeedUp()
		{
			currentSpeed += 2;
		}

		public void SlowDown()
		{
			currentSpeed -= 5;
		}

		public string ShowCurrentSpeed()
		{
			return currentSpeed.ToString();
		}

		public void StartEngine()
		{
			Console.WriteLine("grgrgrgrgrg");
		}
	}
}