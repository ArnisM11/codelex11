using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace Hierarchy.Test
{
    public class MouseTest
    {
        public Mouse m1 = new Mouse("Pelite","Mouse",2.4,5,"Riga");

        [Test]
        public void CreateMouse_GetMouseName_ReturnsCorrectName()
        {
            m1.AnimalName.Should().Be("Pelite");
        }
        [Test]
        public void CreateMouse_CreateObjectWithEmptyName_ThrowsInvalidNameException()
        {
            Action act = () => m1 = new Mouse("", "Mouse", 2.4, 5, "Riga");
            act.Should().Throw<InvalidNameException>();
        }

        [Test]
        public void CreateMouse_GiveInvalidRegion_ShouldThrowInvalidRegionException()
        {
            Action act = () => m1 = new Mouse("Peliite", "Mouse", 2.4, 5, "");
            act.Should().Throw<InvalidRegionException>();
        }
        [Test]
        public void CreateMouse_SetValidTigerWeight_ShouldBeProvidedWeight()
        {
            m1.AnimalWeight = 26.5;
            m1.AnimalWeight.Should().Be(26.5);
        }
        [Test]
        public void ToString_PrintOutInCorrectFormat()
        {
            m1.ToString().Should().Be(new string(m1.AnimalType + " [" + m1.AnimalName + ", " + m1.AnimalWeight + ", " + m1.LivingRegion + ", " + m1.FoodEaten + "]"));
        }
        [Test]
        public void MakeSound_MakesRightSound()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            m1.MakeSound();
            var output = stringWriter.ToString();
            Assert.That(output, Is.EqualTo($"{"miumiu"}\r\n"));
        }
        [Test]
        public void Eat_ProvidedFoodAnimalDoesNotEat_QuantityOfFoodDoesNotIncrease()
        {
            int eatenBefore = m1.FoodEaten;
            Console.WriteLine(eatenBefore);
            Meat meat2 = new Meat(4);
            m1.Eat(meat2);
            m1.FoodEaten.Should().Be(eatenBefore);
        }
        [Test]
        public void Eat_GiveValidFood_IncreasesQuantityOfFood()
        {
            int eatenBefore = m1.FoodEaten;
            Vegetable v1 = new Vegetable(5);
            m1.Eat(v1);
            m1.FoodEaten.Should().Be(5 + eatenBefore);
        }

        

    }
}
