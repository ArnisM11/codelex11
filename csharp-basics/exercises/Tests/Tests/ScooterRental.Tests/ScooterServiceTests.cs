using System;
using NUnit.Framework;
using System.Collections.Generic;
using ScooterRental;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FluentAssertions;


namespace ScooterRental.Tests
{
    public class ScooterServiceTests
    {
        private IScooterService _scooterService;
        private List<Scooter> _scooters;

        [SetUp]
        public void Setup()
        {
            _scooters = new List<Scooter>();
            _scooterService = new ScooterService(_scooters);
        }
        [Test]
        public void AddScooter_AddValidScooter_ScooterAdded()
        {
            _scooterService.AddScooter("1", 1m);
            _scooters.Count.Should().Be(1);
        }
        [Test]
        public void AddScooter_AddScooterWithoutId_ThrowsScooterIdNotProvidedException()
        {
            Action act = () => _scooterService.AddScooter("", 0.1m);
            act.Should().Throw<ScooterIdNotProvidedException>();
        }
        [Test]
        public void AddScooter_AddScooterWithNullId_ThrowsScooterIdNotProvidedException()
        {
            Action act = () => _scooterService.AddScooter("", 0.1m);
            act.Should().Throw<ScooterIdNotProvidedException>();
        }
        [Test]
        public void AddScooter_AddScooterWithBadPrice_ThrowsInvalidPriceException()
        {
            Action act = () => _scooterService.AddScooter("1", -5);
            act.Should().Throw<InvalidPriceException>();
        }
        [Test]
        public void RemoveScooter_NullIdProvided_ThrowsScooterIdNotProvidedException()
        {
            Action act = () => _scooterService.RemoveScooter(null);
            act.Should().Throw<ScooterIdNotProvidedException>();
        }
        [Test]
        public void RemoveScooter_EmptyIdProvided_ThrowsScooterNotFoundException()
        {
            Action act = () => _scooterService.RemoveScooter("3");
            act.Should().Throw<ScooterNotFoundException>();
        }
        [Test]
        public void RemoveScooter_InvalidIdProvided_ThrowsScooterIdNotProvidedException()
        {
            Action act = () => _scooterService.RemoveScooter("");
            act.Should().Throw<ScooterIdNotProvidedException>();
        }
        [Test]
        public void RemoveScooter__ThrowsScooterIdNotProvidedException()                     
        {
            Action act = () => _scooterService.RemoveScooter("");
            act.Should().Throw<ScooterIdNotProvidedException>();
        }
        [Test]
        public void GetScooters_ReturnsAllScooters()
        {
            _scooterService.GetScooters().Count.Should().Be(0);
        }
        [Test]
        public void GetScootersById_ValidIdProvided_ReturnsScooter()
        {
            var scooter = new Scooter("1", 2m);
            _scooters.Add(scooter);
            _scooterService.GetScooterById(scooter.Id).Should().Be(scooter);
        }
        
        [Test]
        public void GetScooterById_EmptyIdProvided_ThrowsScooterNotFoundException()
        {
            Action act = () => _scooterService.GetScooterById("");
            act.Should().Throw<ScooterIdNotProvidedException>();
        }
        [Test]
        public void GetScooterById_InvalidIdProvided_ThrowsScooterNotFoundException()
        {
            Action act = () => _scooterService.GetScooterById("3");
            act.Should().Throw<ScooterNotFoundException>();
        }
        [Test]
        public void GetScooterById_NullIdProvided_ThrowsScooterIdNotProvidedException()
        {
            Action act = () => _scooterService.GetScooterById(null);
            act.Should().Throw<ScooterIdNotProvidedException>();
        }
    }
}