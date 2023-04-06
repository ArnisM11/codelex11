using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{ 
    public class Rental
    {
        public string Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal Price { get; set; }
        public Scooter Scooter { get;set; }

        public TimeSpan Duration
        {
            get
            {
                if (EndTime.HasValue)
                {
                    return EndTime.Value - StartTime;
                }
                else
                {
                    return TimeSpan.Zero;
                }
            }
        }

    }
}
