using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text.Json;
using System.IO;
using WorldBank_LINQ.Models;

namespace WorldBank_LINQ
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
            foreach (Account account in accountsList)
            {
                if (account.AccountNumber == accountNumber && account.Password == Password)
                {
                    return account;
                }
            }
            return null;

        }
        public void SaveData()
        {
            var options = new JsonSerializerOptions {WriteIndented = true};
            string jsonText = JsonSerializer.Serialize(accountsList, options);

            File.WriteAllText("bank_data.json", jsonText);
        }
        public void LoadData()
        {
            if (File.Exists("bank_data.json"))
            {
                string jsonText = File.ReadAllText("bank_data.json");
                accountsList = JsonSerializer.Deserialize<List<Account>>(jsonText);
            }
        }
    }
}

