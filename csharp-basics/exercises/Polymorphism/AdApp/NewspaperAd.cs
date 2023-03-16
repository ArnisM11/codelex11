namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private int _rate;

        public NewspaperAd(int column, int rate,int fee) : base(fee)
        {
            _column = column;
            _rate = rate;
        } 
        

        public NewspaperAd(int fee) : base(fee)
        {
        }

        private new int Cost()
        {
            var fee = base.Cost();
            return fee;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}