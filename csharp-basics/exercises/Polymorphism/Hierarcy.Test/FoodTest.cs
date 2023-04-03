using System;
using FluentAssertions;
using NUnit.Framework;

namespace Hierarchy.Test
{
    public class FoodTest
    {
        public Meat m1 = new Meat();
        public Vegetable v1 = new Vegetable();

        [Test]
        public void CreateFood_GiveNegativeFoodQuantity_ShouldThrowInvalidFoodException()
        {
            Action act = () => m1 = new Meat(-5);
            act.Should().Throw<InvalidFoodException>();
        }
        [Test]
        public void CreateFood_GetAmountOfFood()
        {
            int amountOfVegetables = 25;
            v1 = new Vegetable(amountOfVegetables);
            v1.Quantity.Should().Be(amountOfVegetables);
        }
        [Test]
        public void CreateFood_GiveNegativeVegetableQuantity_ShouldThrowInvalidFoodException()
        {
            Action act = () => v1 = new Vegetable(-5);
            act.Should().Throw<InvalidFoodException>();
        }

    }
}
