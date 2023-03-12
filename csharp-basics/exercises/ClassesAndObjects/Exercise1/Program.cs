namespace Exercise1
{
    
    class Product
    {
        public string _name;
        public double _priceAtStart;
        public int _amountAtStart;

        private Product(string name,double priceAtStart,int amountAtStart)
        {
            this._name = name;
            this._priceAtStart = priceAtStart;
            this._amountAtStart = amountAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine(_name + ", price " + _priceAtStart + " , amount " + _amountAtStart);
        }

        public void ChangeQuantity(int newAmount)
        {
            _amountAtStart = newAmount;
        }

        public void ChangePrice(double newPrice)
        {
            _priceAtStart = newPrice;
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