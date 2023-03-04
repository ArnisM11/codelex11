namespace FuelConsumptionCalculator
{
    public class Car
    {
        double startKilometers;
        double endKilometers;
        double liters;
        public Car(double startOdo,double endingOdo, double liters)
        {
            this.startKilometers = startOdo;
            this.endKilometers = endingOdo;
            this.liters = liters;
        }
        public Car(double startOdo)
        {
            this.startKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            return (endKilometers-startKilometers)/liters;
        }

        private double ConsumptionPer100Km()
        {
            return 0;
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
        }
    }
}
