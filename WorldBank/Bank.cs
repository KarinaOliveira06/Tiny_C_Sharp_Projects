using System.Collections.Generic;
using System.Security.Principal;

namespace WorldBank
{
    class Bank
    {
        private List<Account> accountsList = new List<Account>();

        public void AddNewAccount(Account newAccount)
        {
            accountsList.Add (newAccount);
        }

        public Account FindAccount (int accountNumber, string Password)
        {
            return null;
        }
    }
}

