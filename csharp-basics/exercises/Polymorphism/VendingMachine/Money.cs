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
            Euros = eur;
            Cents = cents;
        }
        public static Money operator +(Money a, Money b)
            => new Money(a.Euros + b.Euros, a.Cents + b.Cents);
    }
}
