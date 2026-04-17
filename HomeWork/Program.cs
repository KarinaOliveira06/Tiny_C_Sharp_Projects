//text operations

namespace HomeWork
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            string idade = Console.ReadLine();

            string saudacoes = $"Olá {nome}, sua idade é de {idade} anos.";
            Console.WriteLine(saudacoes);
        }
    }
}