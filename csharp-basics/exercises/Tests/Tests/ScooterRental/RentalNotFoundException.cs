using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    public class RentalNotFoundException : Exception
    {
        public RentalNotFoundException() : base("Rental not found") { }
    }
}
