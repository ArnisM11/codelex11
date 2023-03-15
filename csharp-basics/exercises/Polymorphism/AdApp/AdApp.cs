using System;
using System.Collections.Generic;
using System.Text;

namespace AdApp
{
    public class AdApp : Advert
    {
        private string dimensions;
        private int numberOfCopies;
        private double costPerCopy;

        public AdApp()
        {
            this.dimensions= string.Empty;
            this.numberOfCopies= 0;
            this.costPerCopy= 0;
        }
        public AdApp(string dimensions, int numberOfCopies, double costPerCopy)
        {
            this.dimensions = dimensions;
            this.numberOfCopies = numberOfCopies;
            this.costPerCopy = costPerCopy;
        }
    }
}
