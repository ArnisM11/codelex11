using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    public class ScooterNotFoundException : Exception
    {
        public ScooterNotFoundException() :base ("Scooter not found.") { }
    }
}
