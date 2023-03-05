namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseCase("Happy Birthday"));
            Console.WriteLine(ReverseCase("MANY THANKS"));
            Console.WriteLine(ReverseCase("sPoNtAnEoUs"));
            Console.ReadKey();
        }
        static string ReverseCase(string str)
        {
            char[] arr = str.ToCharArray();
            for(int i = 0; i< str.Length; i++)
            {
                if (Char.IsLower(arr[i]))
                {
                    arr[i] = Char.ToUpper(arr[i]);
                }
                else if (Char.IsUpper(arr[i]))
                {
                    arr[i] = Char.ToLower(arr[i]);
                }
            }
            return new string(arr);
        }
    }
}