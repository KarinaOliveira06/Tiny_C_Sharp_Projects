using System;
using System.Text.Json;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace WorldBank_LINQ
{
    class Account : User
    {
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public decimal SavingsBalance { get; set; }

        public override void DisplayRole()
        {
        Console.WriteLine($"[CLIENT BADGE] Name: {Name} | Account Number: {AccountNumber}");
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool GuardInSavings(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                SavingsBalance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool GetFromSavings(decimal amount)
        {
            if (amount <= SavingsBalance)
            {
                SavingsBalance -= amount;
                Balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}