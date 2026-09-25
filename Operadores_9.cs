using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o seu nome: ");
        string nome = Console.ReadLine().Trim();

        if (nome.Equals("Wilson", StringComparison.OrdinalIgnoreCase) || nome.Equals("Gloria", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Olá, bem-vindo(a) de volta!");
        }
    }
}
