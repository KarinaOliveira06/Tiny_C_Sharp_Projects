using System.Runtime.InteropServices;

namespace WorldBank
{
    class Program
    {
        static void Main()
        {
            if (Option == 1)
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
                newClientAccount.Number = typedNumber;
                newClientAccount.Balance = 0;

                myBank.AddNewAccount(newClientAccount);

                Console.WriteLine("Account created sucessfully, press enter to continue.");
                Console.ReadLine();
                Console.Clear();
            }
            else if (Option == 2)
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
                }
                
                else
                {
                    Console.WriteLine("Invalid account number or password! Press Enter to try again.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}