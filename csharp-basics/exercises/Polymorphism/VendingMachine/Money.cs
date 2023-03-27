using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public struct Money
    {
        public int Euros { get; set; }
        public int Cents { get; set; }

        public Money(int eur, int cents)
        {
            this.Euros = eur;
            this.Cents = cents;
        }
    }
}
