namespace AdApp
{
    public class Hoarding: Advert
    {
        private int _rate;
        private int _numDays;

        public Hoarding(int rate, int numDays, int fee) : base(fee)
        {
            _rate = rate;
            _numDays = numDays;
        }
        public Hoarding(int fee) : base(fee)
        {
        }

        public new int Cost() 
        {
            return base.Cost();
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}