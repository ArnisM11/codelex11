using System;
using System.Xml.Linq;


namespace Exercise9
{
    public class BankAccount
    {
        public double balance;
        public string name;
        public BankAccount(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }
        public string ShowUserNameAndBalance()
        {
            if(balance < 0) return (name + ", -$" + -Math.Round(balance,2));
            return new string(name + ", $" + Math.Round(balance,2));
        }
    }
}



