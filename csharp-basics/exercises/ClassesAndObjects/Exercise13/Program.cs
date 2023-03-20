namespace Exercise13 {
    class Program
    {
        static void Main(string[] args)
        {
            Smoothie s1 = new Smoothie(new string[] { "Banana" });
            s1.Ingredients();

            Console.WriteLine(s1.GetCost());
            Console.WriteLine(s1.GetPrice());
            Console.WriteLine(s1.GetName());

            Smoothie s2 = new Smoothie(new string[] { "Raspberries", "Strawberries", "Blueberries" });
            Console.WriteLine(s2.GetCost());
            Console.WriteLine(s2.GetPrice());
            Console.WriteLine(s2.GetName());

            Console.ReadKey();
        }
    }
}
