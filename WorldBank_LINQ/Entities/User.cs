namespace WorldBank_LINQ.Entities
{
    class User
    {
        public string Name {get; set;}
        public string Password {get; set;}
        public virtual void DisplayRole()
        {
            Console.WriteLine("Generic phrase.");
        }
    }
}