using System;
using FluentAssertions;
using NUnit.Framework;
using Hierarchy;
using System.IO;

namespace Hierarchy.Test
{
    public class TigerTest
    {
        //private Tiger t1 = new Tiger("", "", 0, 0, "");
        public Tiger t1 = new Tiger("Tigris", "Tiger", 25.5, 0, "Riga");

        [SetUp]
        public void Setup()
        { 
            t1 = new Tiger("Tigris","Tiger",25.5,0,"Riga");
        }

        [Test]
        public void CreateTiger_TypeProvided_TypeShouldBeTiger()
        {
            t1.AnimalType.Should().Be("Tiger");
        }

        [Test]
        public void CreateTiger_GetAnimalType_TypeShouldBeTiger()
        {
            t1.AnimalType.Should().Be("Tiger");
        }

        [Test]
        public void Eat_ProvideCorrectFood_QuantityOfFoodIncreases()
        {
            int eatenBefore = t1.FoodEaten;
            Meat m1 = new Meat(4);
            t1.Eat(m1);
            t1.FoodEaten.Should().Be((m1.Quantity + eatenBefore));
        }
        [Test]
        public void Eat_ProvidedFoodAnimalDoesNotEat_QuantityOfFoodDoesNotIncrease()
        {
            int eatenBefore = t1.FoodEaten;
            Vegetable v1 = new Vegetable(4);
            t1.Eat(v1);
            t1.FoodEaten.Should().Be(eatenBefore);
        }
        [Test]
        public void ToString_PrintOutInCorrectFormat()
        {
            t1.ToString().Should().Be(new string(t1.AnimalType + " [" + t1.AnimalName + ", " + t1.AnimalWeight + ", " + t1.livingRegion + ", " + t1.FoodEaten + "]"));
        }
        [Test]
        public void CreateTiger_SetValidTigerWeight_ShouldBeProvidedWeight()
        {
            t1.AnimalWeight = 26.5;
            t1.AnimalWeight.Should().Be(26.5);
        }
        [Test]
        public void CreateTiger_SetInvalidWeightTiger_ShouldThrowInvalidWeightException()
        {
            Action act = () => new Tiger("Tigra", "Tiger", -25.5, 0, "Riga");
            act.Should().Throw<InvalidWeightException>();
        }

        [Test]
        public void CreateTiger_SetInvalidRegion_ShouldThrowInvalidRegionException()
        {
            Action act = () => new Tiger("Tigra", "Tiger", 25.5, 0, "");
            act.Should().Throw<InvalidRegionException>();
        }
        [Test]
        public void MakeSound_MakesRightSound()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            t1.MakeSound();
            var output = stringWriter.ToString();
            Assert.That(output,Is.EqualTo($"{"RAAAWRRRR"}\r\n"));
        }
    }
}