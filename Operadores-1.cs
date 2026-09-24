using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a idade do usuario: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Possui carteira de motorista? (sim/não): ");
        string resposta = Console.ReadLine().ToLower().Trim();

        if (idade > 18 && resposta == "sim")
        {
            Console.WriteLine("Voce pode dirigir: ");
        }

    }
}
