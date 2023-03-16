namespace AdApp
{
    public class TVAd: Advert
    {
        private int _airTimeInS;
        private int _rate;
        private bool _isPeak;

        public TVAd(int airTimeInS,int rate,int fee, bool isPeak) : base(fee)
        {
            this._airTimeInS= airTimeInS;
            this._isPeak= isPeak;
            this._rate= rate;
        }
        public TVAd(int fee) : base(fee)
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