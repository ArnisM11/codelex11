using System;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuInput = 1;
            double balance = 0.0;
            
            Product[] products = new Product[6];
            VendingMachine machine1 = new VendingMachine("Vending machine #1",false,new Money(), products);
            machine1.UpdateProduct(0, "Snickers", new Money(2 , 0), 3);
            machine1.UpdateProduct(1, "Mars", new Money(1 , 50), 1);
            machine1.UpdateProduct(2, "Bounty", new Money(1, 20), 4);
            machine1.UpdateProduct(3, "Water", new Money(1, 0), 10);
            machine1.UpdateProduct(4, "Coca-Cola", new Money(1, 40), 9);
            machine1.UpdateProduct(5, "Fanta", new Money(1, 40), 8);

            Console.WriteLine("Welcome to the wending machine " + machine1.Manufacturer);
            
           
            while (menuInput != 0)
            {
                machine1.PrintAllProducts();
                menuInput = showMenu();
                switch (menuInput)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("Enter product number (" + 1 + "-" + products.Length + ") -> ");
                        int num = int.Parse(Console.ReadLine());
                        Console.Write("Enter product name -> ");
                        string name = Convert.ToString(Console.ReadLine());
                        Console.Write("Enter product price in eur -> ");
                        int priceE = int.Parse(Console.ReadLine());
                        Console.Write("Enter product price in cents -> ");
                        int priceC = int.Parse(Console.ReadLine());
                        Console.Write("Enter product quantity -> ");
                        int quantity = int.Parse(Console.ReadLine());
                        machine1.UpdateProduct(num-1, name, new Money(priceE, priceC), quantity);
                        Console.WriteLine("Product updated!");
                        break;
                    case 2:
                        char answer = ' ';
                        Console.Write("Choose product number (" + 1 + "-" + products.Length + ") -> ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Product price is EUR " + products[num1 - 1].Price.Euros + ", " + products[num1 - 1].Price.Cents);
                        double productPrice = products[num1 - 1].Price.Euros + (products[num1 - 1].Price.Cents / 100.0);
                        Console.WriteLine("Your balance is : EUR " + balance);
                        if (balance >= productPrice)
                        {
                            Console.WriteLine("Write y to buy");
                            answer = char.Parse(Console.ReadLine());
                            if(answer == 'y')
                            {
                                balance -= productPrice;
                                machine1.UpdateProduct(num1-1, products[num1 - 1].Name, new Money(products[num1 - 1].Price.Euros, products[num1-1].Price.Cents), products[num1-1].Available - 1);
                                Console.WriteLine("Product succesfully bought!");
                            }
                        }

                        else Console.WriteLine("Your balance is to low, refill it!");
                        break;
                    case 3:
                        Console.WriteLine("Refill balance by writing (0,10, 0,20, 0,50, 1,00, 2,00) or 0 to exit ");
                        bool isValidInput = false;

                        while (!isValidInput)
                        {
                            Console.Write("Enter coin value: ");
                            string input = Console.ReadLine();

                            if (double.TryParse(input, out double coinValue))
                            {
                                switch (coinValue)
                                {
                                    case 0.10:
                                    case 0.20:
                                    case 0.50:
                                    case 1.00:
                                    case 2.00:
                                        balance += coinValue;
                                        break;
                                    case 0:
                                        Console.WriteLine("Exiting.");
                                        isValidInput = true;
                                        break;
                                    default:
                                        Console.WriteLine("Invalid input. Please try again.");
                                        continue;
                                }
                                Console.WriteLine($"Current balance: {balance.ToString("N2")} EUR");
                            }

                            else
                            {
                                Console.WriteLine("Invalid input. Please try again.");
                                continue;
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Your balance is : EUR " + balance);
                        break;
                    default:
                        break;
                }
            }
            Console.ReadLine();
        }
        public static int showMenu()
        {
            int res = 0;
            Console.WriteLine();
            Console.WriteLine("Choose action to perform");
            Console.WriteLine("Update a product - 1");
            Console.WriteLine("Buy a product - 2");
            Console.WriteLine("Refill balance - 3");
            Console.WriteLine("Show balance - 4");
            Console.WriteLine("Exit - 0");
            res = int.Parse(Console.ReadLine());
            return res;
        }
    }
}
