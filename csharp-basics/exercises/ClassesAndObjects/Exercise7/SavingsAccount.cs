using System;

namespace Exercise7
{
    class SavingsAccount
    {
        public int AnnualInterestRate;
        public float Balance;

        public SavingsAccount(int balance)
        {
            this.Balance = balance;
        }

        public void WithdrawBalance(int amount)
        {
            this.Balance -= amount;
        }

        public void DepositInBalance(int amount)
        {
            this.Balance += amount;
        }

        public void AddMonthlyInterest()
        {
            float monthlyInterestRate = (float)AnnualInterestRate / (float)12;
            Balance += monthlyInterestRate * Balance;
        }
    }
}
