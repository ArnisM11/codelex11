namespace Exercise1
{
    
    class Product
    {
        public string name;
        public double priceAtStart;
        public int amountAtStart;
        public Product(string name,double priceAtStart,int amountAtStart)
        {
            this.name = name;
            this.priceAtStart = priceAtStart;
            this.amountAtStart = amountAtStart;
        }
        public void PrintProduct()
        {
            Console.WriteLine(name + ", price " + priceAtStart + " , amount " + amountAtStart);
        }
        public void ChangeQuantity(int newAmount)
        {
            amountAtStart = newAmount;
        }
        public void ChangePrice(double newPrice)
        {
            priceAtStart = newPrice;
        }
        static void Main(string[] args)
        {
            Product mouse = new Product("Logitech mouse", 70.00d, 14);
            Product phone = new Product("Iphone 5s", 999.99, 3);
            Product printer = new Product("Epson EB-U05", 440.46, 1);
            mouse.PrintProduct();
            phone.PrintProduct();
            printer.PrintProduct();
            printer.ChangeQuantity(25);
            printer.PrintProduct();
            mouse.ChangePrice(55.55);
            mouse.PrintProduct() ;
            Console.ReadKey();
        }
    }
}