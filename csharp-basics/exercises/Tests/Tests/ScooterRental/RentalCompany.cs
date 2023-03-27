using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    public class RentalCompany : IRentalCompany
    {
        public string Name { get; }
        private readonly IScooterService _scooterService;
        
        public RentalCompany(string name, IScooterService scooterService)
        {
            Name = name;
            _scooterService = scooterService;
        }

        public void StartRent(string id)
        {
            var scooter = _scooterService.GetScooterById(id);
            scooter.IsRented = true;
        }
        public decimal EndRent(string id)
        {
            var scooter = _scooterService.GetScooterById(id);
            
            return 0;
        }
        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            throw new System.NotImplementedException();
        }
    }
}
