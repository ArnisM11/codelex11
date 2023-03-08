using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account mattsAccount = new Account("Matt`s account", 1000);
            Account myAccount = new Account("My account", 0);
            Account edsAccount = new Account("Eduards account", 0);
            Transfer(mattsAccount, myAccount, 50);
            Transfer(myAccount, edsAccount, 25);
            Console.WriteLine(mattsAccount);
            Console.WriteLine(myAccount);
            Console.WriteLine(edsAccount);
            Console.ReadKey();
        }
        public static void Transfer(Account from, Account to, double howMuch)
        {
            from.Withdrawal(howMuch);
            to.Deposit(howMuch);
        }
    }
}
