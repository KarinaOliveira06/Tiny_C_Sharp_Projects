namespace WorldBankUpgraded
{
    class Admin : User
    {
        public string EmployeeCode {get; set;}
        public void GreetAdmin()
        {
            Console.WriteLine($"[SYSTEM ALERT] Bem-vindo ao painel de controle, Administrador {Name}.");
        }
    }
}