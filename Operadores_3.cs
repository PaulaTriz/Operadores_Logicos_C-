using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Possui diploma de ensino superior? (sim/nao): ");
        string diploma = Console.ReadLine().ToLower().Trim();

        Console.Write("Digite a sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        if (diploma == "sim" && idade > 21)
        {
            Console.WriteLine("Parabens, voce esta qualificado para a vaga! ");
        }
    }
}


