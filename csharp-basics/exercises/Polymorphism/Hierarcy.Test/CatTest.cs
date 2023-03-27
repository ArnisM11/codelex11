using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hierarchy;
using FluentAssertions;
using NUnit.Framework;

namespace Hierarchy.Test
{
    
    public class CatTest
    {
        public Cat c1 = new Cat("Muris", "cat", 2.5, 2, "Sigulda");

        [SetUp]
        public void Setup()
        {
            c1 = new Cat("Muris", "cat", 2.5, 2, "Sigulda");
        }

        [Test]
        public void CreateCat_TestAsNameProvided_NameShouldBeMuris()
        {
            c1.AnimalName.Should().Be("Muris");
        }

        [Test]
        public void CreateCat_CreateObjectWithEmptyName_ThrowsInvalidNameException()
        {
            Action act = () => c1 = new Cat("", "cat", 2.5, 2, "Sigulda");
            act.Should().Throw<InvalidNameException>();
        }

        [Test]
        public void Eat_ProvideCorrectFood_QuantityOfFoodIncreases()
        {
            int eatenBefore = c1.FoodEaten;
            Vegetable v1 = new Vegetable(5);
            c1.Eat(v1);
            c1.FoodEaten.Should().Be((5 + eatenBefore));
        }

        [Test]
        public void Eat_ProvideInvalidFood_ThrowsInvalidFoodException()
        {
            Vegetable v1 = new Vegetable(0);
            Action act = () => c1.Eat(v1);
            act.Should().Throw<InvalidFoodException>();
        }

        [Test]
        public void ToString_PrintOutInCorrectFormat()
        {
            c1.ToString().Should().Be(new string(c1.AnimalType + " [" + c1.AnimalName + ", " + c1.Breed + ", " + c1.AnimalWeight + ", " + c1.LivingRegion + ", " + c1.FoodEaten + "]"));
        }
    }
}
