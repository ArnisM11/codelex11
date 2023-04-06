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
        public List<Rental> rentals;


        public RentalCompany(string name, IScooterService scooterService,List<Rental> rentals1)
        {
            rentals = rentals1;
            Name = name;
            _scooterService = scooterService;
        }

        public void StartRent(string id)
        {
            var scooter = _scooterService.GetScooterById(id);
            
            Rental r1 = new Rental()
            {
                Id = scooter.Id,
                StartTime = DateTime.Now,
                Scooter = scooter
            };
            rentals.Add(r1);
            scooter.IsRented = true;
        }
        public decimal EndRent(string id)
        {
            var scooter = _scooterService.GetScooterById(id);
            Rental rental = rentals.SingleOrDefault(x => x.Id == id && !x.EndTime.HasValue);
            if (rental == null)
            {
                throw new RentalNotFoundException();
            }
            rental.EndTime = DateTime.Now;
            var rentalDuration = rental.Duration;
            var rentalPrice = CalculateRentalPrice(rentalDuration, scooter.PricePerMinute);
            
            //rentals.Add(rentalInfo);
            scooter.IsRented = false;
            return rentalPrice;
        }
        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            decimal totalIncomeByYear = 0;
            IEnumerable<Rental> rentalsInYear = year.HasValue
                ? rentals.Where(r => r.StartTime.Year == year.Value)
                : rentals;

            foreach (var rental in rentalsInYear)
            {
                if (!includeNotCompletedRentals && !rental.EndTime.HasValue)
                {
                    continue;
                }

                decimal rentalPrice = rental.Price;
                if (!rental.EndTime.HasValue && includeNotCompletedRentals)
                {
                    TimeSpan timeElapsed = DateTime.Now - rental.StartTime;
                    totalIncomeByYear += CalculateRentalPrice(timeElapsed,rental.Scooter.PricePerMinute);
                }

                totalIncomeByYear += rentalPrice;
            }
            return totalIncomeByYear;
        }

        public decimal CalculateRentalPrice(TimeSpan rentalDuration, decimal pricePerMinute)
        {
            decimal dailyRateMax = 20;
            //int fullDays = (int)rentalDuration.TotalDays;
            decimal rentalPrice = (decimal)rentalDuration.TotalMinutes * pricePerMinute;
            rentalPrice = Math.Round(rentalPrice, 2);
            rentalPrice = Math.Min(rentalPrice, dailyRateMax);
            //rentalPrice += (fullDays * dailyRate);
            return rentalPrice;
        }
    }
}
