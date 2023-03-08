namespace FuelConsumptionCalculator
{
    public class Car
    {
        double _startKilometers;
        double _endKilometers;
        double _liters;
        public Car(double startOdo,double endingOdo, double liters)
        {
            this._startKilometers = startOdo;
            this._endKilometers = endingOdo;
            this._liters = liters;
        }
        public Car(double startOdo)
        {
            this._startKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            double distance = _endKilometers - _startKilometers;
            return ((double)_liters / (double)distance);
        }

        public double ConsumptionPer100Km()
        {
            return (double)(_endKilometers-_startKilometers)/(double)10;
        }

        public bool GasHog()
        {
            if (ConsumptionPer100Km() > 15) return true;
            else return false;
        }

        public bool EconomyCar()
        {
            if (ConsumptionPer100Km() < 5) return true;
            else return false;
        }

        public void FillUp(int mileage, double liters)
        {
            _liters += liters;
            _startKilometers = _endKilometers;
            _endKilometers = mileage;
        }
    }
}
