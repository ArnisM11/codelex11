using System;
using System.Xml.Linq;


namespace Exercise9
{
    public class BankAccount
    {
        public double Balance;
        public string Name;
        public BankAccount(string name, double balance)
        {
            this.Name = name;
            this.Balance = balance;
        }
        public string ShowUserNameAndBalance()
        {
            if(Balance < 0) return (Name + ", -$" + -Math.Round(Balance,2));
            return new string(Name + ", $" + Math.Round(Balance,2));
        }
    }
}



