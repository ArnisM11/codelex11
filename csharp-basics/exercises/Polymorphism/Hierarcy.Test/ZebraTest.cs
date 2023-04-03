using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using System.IO;

namespace Hierarchy.Test
{
    public class ZebraTest
    {
        public Zebra z1 = new Zebra("Zebris", "Zebra", 45.0, 2, "Jurmala");

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void CreateZebra_SetInvalidName_ShouldThrowInvalidNameException()
        {
            Action act = () => z1 = new Zebra("", "Zebra", 45.0, 2, "Jurmala");
            act.Should().Throw<InvalidNameException>();
        }

        [Test]
        public void Eat_GiveValidFood_IncreasesQuantityOfFood()
        {
            int eatenBefore = z1.FoodEaten;
            Vegetable v1 = new Vegetable(5);
            z1.Eat(v1);
            z1.FoodEaten.Should().Be(5+eatenBefore);
        }
        [Test]
        public void Eat_ProvidedFoodAnimalDoesNotEat_QuantityOfFoodDoesNotIncrease()
        {
            int eatenBefore = z1.FoodEaten;
            Meat m1 = new Meat(4);
            z1.Eat(m1);
            z1.FoodEaten.Should().Be(eatenBefore);
        }
        [Test]
        public void ToString_PrintOutInCorrectFormat()
        {
            z1.ToString().Should().Be(new string(z1.AnimalType + " [" + z1.AnimalName + ", " + z1.AnimalWeight + ", " + z1.LivingRegion + ", " + z1.FoodEaten + "]"));
        }
        [Test]
        public void MakeSound_MakesRightSound()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            z1.MakeSound();
            var output = stringWriter.ToString();
            Assert.AreEqual($"{"Brrrrr"}\r\n", output);
        }
    }
}
