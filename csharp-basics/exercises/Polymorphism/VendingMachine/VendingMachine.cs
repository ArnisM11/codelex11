using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        public string Manufacturer { get; set; }
        public bool HasProducts { get; set; }
        public Money Amount { get; set; }
        public Product[] Products { get; set; }

        public VendingMachine(string manufacturer, bool hasProducts, Money amount, Product[] products)
        {
            Manufacturer = manufacturer;
            HasProducts = hasProducts;
            Amount = amount;
            Products = products;
        }

        public Money InsertCoin(Money amount)
        {
            if (amount.Euros == 0 && amount.Cents == 10 || amount.Euros == 0 && amount.Cents == 20 ||
                amount.Euros == 0 && amount.Cents == 50 || amount.Euros == 1 && amount.Cents == 0 ||
                amount.Euros == 2 && amount.Cents == 0)
            {
                Amount += amount;
            }
            return amount;
        }

        public Money ReturnMoney()
        {
            return Amount;
        }

        public bool AddProduct(string name, Money price, int count)
        {
            if (string.IsNullOrEmpty(name)) throw new InvalidNameException();
            if (count <= 0) throw new InvalidProductCountException();
            Product[] tmp = new Product[this.Products.Length + 1];
            Product p1 = new Product();
            p1.Name = name;
            p1.Price = price;
            p1.Available += count;
            tmp[tmp.Length-1] = p1;
            this.Products = tmp;
            HasProducts = true;
            return true;
        }

        public bool UpdateProduct(int productNumber, string name, Money price, int amount)
        {
            Product p1 = new Product();
            p1.Name = name;
            p1.Price = price;
            p1.Available += amount;
            Products[productNumber] = p1;
            HasProducts = true;
            return true;
        }
        public void PrintAllProducts()
        {
            var result = "";
            Console.WriteLine();
            Console.WriteLine("-#-"+"+---Name----+-Price(eur)-+-Price(c)-+-Available-" );
            foreach(var prod in Products)
            {
                result = " "+(Array.IndexOf(Products,prod)+1).ToString().PadRight(4) + prod.Name.PadRight(16).PadLeft(3) + (prod.Price.Euros).ToString().PadRight(12).PadLeft(3) + prod.Price.Cents.ToString().PadRight(12).PadLeft(3) + prod.Available.ToString().PadRight(5);
                if(prod.Available >= 1) Console.WriteLine(result);
            } 
            
        }
        
    }
}
