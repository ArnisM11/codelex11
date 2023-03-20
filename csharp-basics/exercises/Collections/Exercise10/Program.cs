namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("a");
            set.Add("b");
            set.Add("c");
            set.Add("d");
            set.Add("e");
            foreach(string letter in set)
            {
                Console.WriteLine(letter);
                set.Remove(letter);
            }
            Console.WriteLine();
            set.Add("a");
            set.Add("a");
            foreach (string letter in set)
            {
                Console.WriteLine(letter);
            }
            Console.ReadKey();
        }
    }
}