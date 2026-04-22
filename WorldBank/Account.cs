using System.Text.Json;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace WorldBank
{
    class Account
    {
        public string Name {get;  set;}
        public string Password {get;  set;}
        public int AccountNumber {get;  set;}
        public decimal Balance {get;  set;}
        
        public void deposit(decimal amount)
        {
            Balance += amount;
        }

        public bool withdraw(decimal amount)
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
    }
}