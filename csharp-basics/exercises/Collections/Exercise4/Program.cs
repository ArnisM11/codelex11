namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "a";
            List<string> list = new List<string>();
            do
            {
                Console.WriteLine("Enter name");
                input = Convert.ToString(Console.ReadLine());
                list.Add(input);
            } while (input != "");
            HashSet<string> hSet = new HashSet<string>(list);
            Console.Write("Unique name list contains : ");
            foreach(string name in hSet)
            {
                Console.Write(name + " ");
            }
            Console.ReadKey();
        }
    }
}