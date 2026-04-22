using System.Collections.Generic;
using System;

namespace HomeWork
{
    class Dictionary
    {
        static void Main()
        {
            Dictionary<int, string> MyDictionary = new Dictionary<int, string>();

            MyDictionary.Add(1, "Hotdog");
            MyDictionary.Add(2, "Hamburguer");

            Console.WriteLine("Choose the number 1 or the number 2");
            String Choose = Console.ReadLine();

            bool strChoose = int.TryParse(Choose, out int Result);

            Console.WriteLine($"You've got {MyDictionary[Result]}!");

        }
    }
}