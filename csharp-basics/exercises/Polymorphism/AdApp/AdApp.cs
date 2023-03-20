using System;
using System.Collections.Generic;
using System.Text;

namespace AdApp
{
    public class AdApp : Advert
    {
        private string _dimensions;
        private int _numberOfCopies;
        private double _costPerCopy;

        public AdApp()
        {
            this._dimensions= string.Empty;
            this._numberOfCopies= 0;
            this._costPerCopy= 0;
        }
        public AdApp(string dimensions, int numberOfCopies, double costPerCopy)
        {
            this._dimensions = dimensions;
            this._numberOfCopies = numberOfCopies;
            this._costPerCopy = costPerCopy;
        }
        public new int Cost()
        {
            return _numberOfCopies*(int)_costPerCopy;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
