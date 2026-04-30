namespace WorldBank_LINQ.Entities
{
    class Admin : User
    {
        public string EmployeeCode {get; set;}
        public override void DisplayRole()
        {
            Console.WriteLine($"[ADMIN BADGE] Authorized Name: {Name} | Master Code: {EmployeeCode}");
        }
        public void GreetAdmin()
        {
            Console.WriteLine($"[SYSTEM ALERT] Welcome to the control panel, administrator {Name}.");
        }
    }
}