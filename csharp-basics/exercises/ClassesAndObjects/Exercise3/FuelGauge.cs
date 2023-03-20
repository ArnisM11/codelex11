using System;

public class FuelGauge
{
	private int _fuelLevel;
	public FuelGauge()
	{
		_fuelLevel= 0;
	}

	public void Fill()
	{
		if (_fuelLevel == 70)
		{
			return;
		}
		_fuelLevel++;
	}

	public void Consume()
	{
		_fuelLevel--;
	}

	public int ReportLevel()
	{
		return _fuelLevel;
	}
}
