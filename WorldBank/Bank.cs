using System.Collections.Generic;
using System.Security.Principal;
using System.Text.Json;
using System.IO;

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
        public void SaveData()
        {
            var options = new JsonSerializerOptions {WriteIndented = true};
            string jsonText = JsonSerializer.Serialize(accountsList, options);

            File.WriteAllText("bank_data.json", jsonText);
        }
    }
}

