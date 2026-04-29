using System;
using System.Runtime.InteropServices;

namespace WorldBankUpgraded
{
    class Program
    {
        static void Main()
        {
            Bank myBank = new Bank();
            myBank.LoadData();

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("=== WELCOME TO WORLD BANK ===");
                Console.WriteLine("[1] Create new account");
                Console.WriteLine("[2] Login");
                Console.WriteLine("[3] Exit");
                Console.Write("Choose an option: ");
                string Option = Console.ReadLine();
                Console.Clear();

                if (Option == "1")
                {
                    Console.WriteLine("=== Create new account ===");

                    Console.Write("Type your name: ");
                    string typedName = Console.ReadLine();

                    Console.Write("Type your password: ");
                    string typedPassword = Console.ReadLine();

                    Console.Write("Type your account number: ");
                    int typedNumber = int.Parse(Console.ReadLine());

                    Account newClientAccount = new Account();

                    newClientAccount.Name = typedName;
                    newClientAccount.Password = typedPassword;
                    newClientAccount.AccountNumber = typedNumber;
                    newClientAccount.Balance = 0;
                    newClientAccount.SavingsBalance = 0;

                    myBank.AddNewAccount(newClientAccount);
                    myBank.SaveData();

                    Console.WriteLine("Account created sucessfully, press enter to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (Option == "2")
                {
                    Console.WriteLine("=== Login with existent account ===");

                    Console.Write("Type your account number: ");
                    int loginNumber = int.Parse(Console.ReadLine());

                    Console.Write("Type your password: ");
                    string loginPassword = Console.ReadLine();

                    Account loggedAccount = myBank.FindAccount(loginNumber, loginPassword);

                    if (loggedAccount != null)
                    {
                        Console.WriteLine($"Login successful, welcome back {loggedAccount.Name}!");
                        Console.ReadLine();
                        Console.Clear();

                        bool isLoggedIn = true;

                        while (isLoggedIn)
                        {
                            Console.WriteLine($"=== ACCOUNT MENU {loggedAccount.Name} ===");
                            Console.WriteLine("[1] Check balance");
                            Console.WriteLine("[2] Deposit");
                            Console.WriteLine("[3] Withdraw");
                            Console.WriteLine("[4] Move money to vault");
                            Console.WriteLine("[5] Get money from vault");
                            Console.WriteLine("[6] Logout");
                            Console.WriteLine("Choose an option:");

                            string loggedOption = Console.ReadLine();

                            if (loggedOption == "1")
                            {
                                Console.WriteLine($"This is your Main balance: {loggedAccount.Balance:C}");
                                Console.WriteLine($"This is your Vault balance: {loggedAccount.SavingsBalance:C}");

                                Console.WriteLine("Press Enter to return to the menu.");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if (loggedOption == "2")
                            {
                                Console.WriteLine($"Please, enter the amount to be deposited: ");
                                decimal depositAmount = decimal.Parse(Console.ReadLine());

                                loggedAccount.Deposit(depositAmount);
                                myBank.SaveData();

                                Console.WriteLine($"Deposit sucessful! Your new balance is {loggedAccount.Balance:C}");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if (loggedOption == "3")
                            {
                                Console.WriteLine($"Please, enter the amount that you want to withdraw: ");
                                decimal withdrawAmount = decimal.Parse(Console.ReadLine());

                                bool isSuccess = loggedAccount.Withdraw(withdrawAmount);

                                if (isSuccess)
                                {
                                    myBank.SaveData();
                                    Console.WriteLine($"Successful! Now your balance is {loggedAccount.Balance:C}");
                                }
                                else
                                {
                                    Console.WriteLine("Transaction failed, insuficcient funds.");
                                }
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if (loggedOption == "4")
                            {
                                Console.WriteLine($"Please, enter the amount to be deposited in your vault: ");
                                decimal depositAmount = decimal.Parse(Console.ReadLine());

                                if (loggedAccount.GuardInSavings(depositAmount))
                                {
                                    myBank.SaveData();
                                    Console.WriteLine($"Successfully moved {depositAmount:C} to your Vault!");
                                    Console.WriteLine($"Your new main balance is {loggedAccount.Balance:C}");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, insufficient funds, please, try again.");
                                }
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if (loggedOption == "5")
                            {
                                Console.WriteLine("How much money do you want to retrieve from your Vault?");
                                decimal amount = decimal.Parse(Console.ReadLine());

                                if (loggedAccount.GetFromSavings(amount))
                                {
                                    myBank.SaveData();
                                    Console.WriteLine($"Sucessfully retrieved {amount:C} to your main Balance!");
                                }
                                else
                                {
                                    Console.WriteLine("Insufficcient funds in Vault.");
                                }
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if (loggedOption == "6")
                            {
                                isLoggedIn = false;
                                Console.WriteLine("Your account has been logged out.");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Invalid option. Press Enter to try again.");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid account number or password! Press Enter to try again.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else if (Option == "0") 
                {
                    Console.WriteLine("=== ADMIN control panel ===");
                    Console.Write("Type the Master code: ");
                    string typedCode = Console.ReadLine();

                    Console.Write("Type the Master password: ");
                    string typedPassword = Console.ReadLine();

                    if (typedCode == "MASTER" && typedPassword == "MASTER123")
                    {
                        Console.Clear();

                        Admin masterAdmin = new Admin();
                        masterAdmin.Name = "Master Admin";
                        masterAdmin.Password = typedPassword;
                        masterAdmin.EmployeeCode = typedCode;

                        masterAdmin.GreetAdmin();

                        Console.WriteLine("\n[1] View all registered accounts");
                        Console.WriteLine("[2] Exit Admin Panel");
                        string adminOpt = Console.ReadLine();

                        if (adminOpt == "1")
                        {
                            Console.WriteLine($"The bank currently has {myBank.accountsList.Count} accounts.");
                        }
                        
                        Console.WriteLine("\nExiting Admin Panel...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("ACCESS DENIED.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else if (Option == "3")
                {
                    Console.WriteLine("Thank you for using WorldBank, see you later!");
                    Console.ReadLine();
                    Console.Clear();

                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Something went wrong. Please, try again.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}