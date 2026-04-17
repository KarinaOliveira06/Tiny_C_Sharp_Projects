namespace HomeWork
{
    class EnumTest
    {
        enum LevelDiff
        {
            Easy = 1,
            Normal = 2,
            Hard = 3
        }
        static void Main()
        {
            Console.WriteLine("Choose the level difficulty: type 1, 2 or 3 ");
            Console.WriteLine($"Easy    Normal    Hard");
            string Level = Console.ReadLine();

            int LevelChosen = int.Parse(Level);

            LevelDiff MyLevel = (LevelDiff)LevelChosen;

            Console.WriteLine($"You choosed {MyLevel} Level!");
        }
    }
}