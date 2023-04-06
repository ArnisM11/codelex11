using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using Moq.AutoMock;

namespace ScooterRental.Tests
{
    public class RentalCompanyTests
    {
        private IRentalCompany _company;
        private const string CompanyName = "test";
        private AutoMocker _mocker;
        private List<Rental> _list;

        [SetUp]
        public void Setup()
        {
            _list = new List<Rental>();
            _mocker = new AutoMocker();
            _company = new RentalCompany(CompanyName,_mocker.GetMock<IScooterService>().Object, _list);
        }

        [Test]
        public void CreateRentalCompany_TestAsNameProvided_NameShouldBeTest()
        {
            _company.Name.Should().Be(CompanyName);
        }

        [Test]
        public void GetRentalId_ReturnsRentalId()
        {
            Rental r1 = new Rental();
            r1.Id = "1";
            r1.Id.Should().Be("1");
        }

        [Test]
        public void GetScooterByRentalList_ReturnsScooter()
        {
            Scooter s1 = new Scooter("1", 2m);
            Rental r1 = new Rental();
            r1.Scooter = s1;
            _list.Add(r1);
            var scooterToTest = _list[0].Scooter;
            scooterToTest.Should().Be(s1);
        }
        [Test]
        public void GetRentalDuration_ReturnsRentalDuration()
        {
            Rental r1 = new Rental();
            r1.Duration.TotalMinutes.Should().Be(0);
        }

        [Test]
        public void GetRentalPrice_ReturnsRentalPrice()
        {
            Rental r1 = new Rental();
            r1.Price.Should().Be(0);
        }

        [Test]
        public void StartRent_ValidIdProvided_ScooterIsRented()
        {
            var scooter = new Scooter("1", 1m);
            var mock = _mocker.GetMock<IScooterService>();
            mock.Setup(x => x.GetScooterById("1")).Returns(scooter);
            _company.StartRent("1");
            scooter.IsRented.Should().BeTrue();
        }
        [Test]
        public void EndRent_ReturnsTotalPriceOfRental()
        {
            var scooter = new Scooter("1", 1m);
            scooter.IsRented = true;
            var rental = new Rental();
            rental.StartTime = DateTime.Now.AddMinutes(-5);
            rental.Id = scooter.Id;
            rental.Price = scooter.PricePerMinute;
            _list.Add(rental);
            var mock = _mocker.GetMock<IScooterService>();
            mock.Setup(x => x.GetScooterById("1")).Returns(scooter);
            var totalPrice = _company.EndRent("1");
            Assert.AreEqual(5.00m,totalPrice);
        }
        [Test]
        public void EndRent_ReturnsTotalPriceOfRental_MaximumDailyFee()
        {
            var scooter = new Scooter("1", 5m);
            scooter.IsRented = true;
            var rental = new Rental();
            rental.StartTime = DateTime.Now.AddMinutes(-5);
            rental.Id = scooter.Id;
            rental.Price = scooter.PricePerMinute;
            _list.Add(rental);
            var mock = _mocker.GetMock<IScooterService>();
            mock.Setup(x => x.GetScooterById("1")).Returns(scooter);
            var totalPrice = _company.EndRent("1");
            Assert.AreEqual(20.00m, totalPrice);
        }


        [Test]
        public void EndRent_TryEndingNonExistingRental_ThrowsRentalNotFoundException()
        {
            Action act = () => _company.EndRent("5");
            act.Should().Throw<RentalNotFoundException>();
        }

        [Test]
        public void EndRent_AddTwoFinishedRentals_CalculateIncome()
        {
            var scooter1 = new Scooter("1", 1m);
            scooter1.IsRented = true;
            var rental1 = new Rental();
            rental1.StartTime = DateTime.Now.AddMinutes(-5);
            rental1.Id = scooter1.Id;
            rental1.Price = scooter1.PricePerMinute;
            _list.Add(rental1);
            var mock = _mocker.GetMock<IScooterService>();
            mock.Setup(x => x.GetScooterById("1")).Returns(scooter1);
            var scooter2 = new Scooter("2", 2m);
            scooter2.IsRented = true;
            var rental2 = new Rental();
            rental2.StartTime = DateTime.Now.AddMinutes(-5);
            rental2.Id = scooter2.Id;
            rental2.Price = scooter2.PricePerMinute;
            _list.Add(rental2);
            var mock2 = _mocker.GetMock<IScooterService>();
            mock2.Setup(x => x.GetScooterById("2")).Returns(scooter2);
            var totalPrice = _company.EndRent("1") + _company.EndRent("2");
            Assert.AreEqual(15.00m,totalPrice);
        }
 
    }
}
