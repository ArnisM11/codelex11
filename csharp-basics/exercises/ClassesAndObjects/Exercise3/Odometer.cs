using System;
namespace Exercise3
{
	public class Odometer
	{
		private int _mileage;
		private FuelGauge _fuelGauge;

		public Odometer(FuelGauge fuelGauge)
        {
            _mileage = 0;
            _fuelGauge = fuelGauge;
        }
        public int Report()
		{
			return _mileage;
		}
		public void Drive()
		{
			if (_mileage < 999999)
			{
				_mileage++;
			}
			else
			{
				_mileage = 0;
			}
			if(_mileage %10 == 0)
			{
				_fuelGauge.Consume();
			}
		}

	}
}
