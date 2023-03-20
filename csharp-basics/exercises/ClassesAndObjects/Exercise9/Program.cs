namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount benben = new BankAccount("Benson", -17.25);

            Console.WriteLine(benben.ShowUserNameAndBalance());

            Console.ReadKey();
        }
    }
}