using System;
using System.IO;
using NUnit.Framework;
using VendingMachine;
using FluentAssertions;


namespace VendingMachine.Tests
{
    public class Tests
    {
       
        public VendingMachine machine1= new VendingMachine("Samsung", false, new Money(), new Product[6]);
        //public Product[] products = new Product[0];
        [SetUp]
        public void Setup()
        {
            machine1.UpdateProduct(0, "Snickers", new Money(2, 0), 3);
            machine1.UpdateProduct(1, "Mars", new Money(1, 50), 1);
            machine1.UpdateProduct(2, "Bounty", new Money(1, 20), 4);
            machine1.UpdateProduct(3, "Water", new Money(1, 0), 10);
            machine1.UpdateProduct(4, "Coca-Cola", new Money(1, 40), 9);
            machine1.UpdateProduct(5, "Fanta", new Money(1, 40), 8);
        }

        [Test]
        public void CreateVendingMachine_GetVendingMachineManufacturer()
        {
            machine1.Manufacturer.Should().Be("Samsung");
        }
        [Test]
        public void CreateVendingMachine_AddProducts_hasProductsShouldBeTrue()
        {
            machine1.HasProducts.Should().BeTrue();
        }

        [Test]
        public void CreateVendingMachine_AddMoney_ShouldReturnMoney()
        {
            machine1.Amount = new Money(2, 50);
            machine1.Amount.Euros.Should().Be(2);
            machine1.Amount.Cents.Should().Be(50);
        }
        [Test]
        public void CreateVendingMachine_AddedSixProducts_ProductsCountShouldBeSix()
        {
            machine1.Products.Length.Should().Be(6);
        }

        [Test]
        public void InsertCoin_InsertValidCoin_ShouldAddAmountOfInsertedCoin()
        {
            machine1.Amount = new Money(0, 0);
            Money m1 = new Money(0,50);
            machine1.InsertCoin(m1);
            machine1.Amount.Euros.Should().Be(m1.Euros);
            machine1.Amount.Cents.Should().Be(m1.Cents);
        }

        [Test]
        public void InsertCoin_InsertInvalidCoin_ShouldGiveBackMoney_AndDoesNotAddToAmount()
        {
            machine1.Amount = new Money(2, 50);
            var invalidValue =  machine1.InsertCoin(new Money(0, 70));
            invalidValue.Euros.Should().Be(0);
            invalidValue.Cents.Should().Be(70);
            machine1.Amount.Euros.Should().Be(2);
            machine1.Amount.Cents.Should().Be(50);
        }

        [Test]
        public void ReturnMoney_ShouldReturnValidAmountOfMoneyAdded()
        {
            machine1 = new VendingMachine("Samsung", false, new Money(2, 50), new Product[6]);
            Money m1 = new Money(2, 50);
            machine1.ReturnMoney().Should().Be(m1);
        }

        [Test]
        public void AddProduct_EnteredInvalidName_ShouldThrowInvalidNameException()
        {
            Action act = () => machine1.AddProduct("", new Money(1, 0), 2);
            act.Should().Throw<InvalidNameException>();
        }
        [Test]
        public void AddProduct_EnteredInvalidCount_ShouldThrowInvalidProductCountException()
        {
            Action act = () => machine1.AddProduct("Snickers", new Money(1, 0), -3);
            act.Should().Throw<InvalidProductCountException>();
        }

        [Test]
        public void AddProduct_EnteredValidProduct_ShouldAddProductToProductArray()
        {
            VendingMachine machine2 = new VendingMachine("Samsung", false, new Money(), new Product[6]);
            var productAdded = machine2.AddProduct("Snickers", new Money(1, 0), 3);
            productAdded.Should().BeTrue();
        }

        [Test]
        public void PrintAllProducts_ShouldPrintOneProductInCorrectFormat()
        {
            Product[] products = new Product[2];
            Product prod1 = new Product();
            prod1.Name = "Snickers";
            prod1.Price = new Money(1, 0);
            prod1.Available = 3;
            products[0] = prod1;
            //products[1] = prod1;
            VendingMachine machine2 = new VendingMachine("Samsung", true, new Money(), products);
            string result = "";
            var stringWriter = new StringWriter();
            foreach (var prod in products)
            {
                result = " " + (Array.IndexOf(products, prod) + 1).ToString().PadRight(4) + prod.Name.PadRight(16).PadLeft(3) + (prod.Price.Euros).ToString().PadRight(12).PadLeft(3) + prod.Price.Cents.ToString().PadRight(12).PadLeft(3) + prod.Available.ToString().PadRight(5);
                if (prod.Available >= 1) Console.WriteLine(result);
            }
            Console.SetOut(stringWriter);
            var outputLines = stringWriter.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual("-#-" + "+---Name----+-Price(eur)-+-Price(c)-+-Avaliable-", outputLines[0]);
            Assert.AreEqual("1   Snickers        1           0           3", outputLines[1]);
        }

        [Test]
        public void Product_GetProductPrice_ShouldReturnValidProductPrice()
        {
            VendingMachine machine2 = new VendingMachine("Samsung", false, new Money(), new Product[0]);
            machine2.AddProduct( "Mars",new Money(1, 0), 5);
            machine2.Products[0].Price.Euros.Should().Be(1);
            machine2.Products[0].Price.Cents.Should().Be(0);
        }
        [Test]
        public void Product_GetProductName_ShouldReturnValidProductName()
        {
            VendingMachine machine2 = new VendingMachine("Samsung", false, new Money(), new Product[0]);
            machine2.AddProduct("Mars", new Money(1, 0), 5);
            machine2.Products[0].Name.Should().Be("Mars");
        }
        

    }
}