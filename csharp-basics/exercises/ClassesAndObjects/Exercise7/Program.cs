using System.Globalization;
namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monthsOpen = 0;
            float totalDeposited = 0;
            float totalWithdrawn = 0;
            float interestEarned = 0;
            Console.Write("How much money is in the account? : ");
            int input = Convert.ToInt32(Console.ReadLine());
            SavingsAccount account1 = new SavingsAccount(input);
            Console.Write("Enter the annual interest rate : ");
            account1.AnnualInterestRate = Convert.ToInt32(Console.ReadLine());
            Console.Write("How long has the account been open (months)? ");
            monthsOpen = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < monthsOpen; i++)
            {
                Console.Write("Enter amount deposited for month " + (i + 1) + " : ");
                input = Convert.ToInt32(Console.ReadLine());
                totalDeposited += input;
                account1.DepositInBalance(input);
                Console.Write("Enter amount withdrawn for month " + (i + 1) + " : ");
                input = Convert.ToInt32(Console.ReadLine());
                totalWithdrawn += input;
                account1.WithdrawBalance(input);
                interestEarned = account1.Balance;
                account1.AddMonthlyInterest();
                interestEarned += account1.Balance;
            }

            Console.WriteLine("Total deposited : " + totalDeposited);
            Console.WriteLine("Total withdrawn : " + totalWithdrawn);
            Console.WriteLine("Interest earned : " + interestEarned);
            Console.WriteLine("Ending balance : " + account1.Balance);
            Console.ReadKey();
        }
    }
}