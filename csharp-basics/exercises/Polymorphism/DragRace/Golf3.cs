using System;

namespace DragRace
{
	public class Raf : ICar
	{
		private int currentSpeed = 0;

		public void SpeedUp()
		{
			currentSpeed += 11;
		}

		public void SlowDown()
		{
			currentSpeed -= 3;
		}

		public string ShowCurrentSpeed()
		{
			return currentSpeed.ToString();
		}

		public void StartEngine()
		{
			Console.WriteLine("klaklaklaklak");
		}
	}
}