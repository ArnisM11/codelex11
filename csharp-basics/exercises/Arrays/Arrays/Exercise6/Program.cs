namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 100);
            }
            int[] array2 = array;
            Console.Write("Array 1 : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            array[array.Length - 1] = -7;
            Console.Write("Array 2 : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.ReadKey();
        }
    }
}