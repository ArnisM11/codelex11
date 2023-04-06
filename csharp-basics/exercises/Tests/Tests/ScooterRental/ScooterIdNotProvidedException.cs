using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    public class ScooterIdNotProvidedException : Exception
    {
        public ScooterIdNotProvidedException() : base("Scooter ID not provided.")
        {

        }
    }
}
