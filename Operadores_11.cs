using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Você é um robô? (sim/nao): ");
        string resposta = Console.ReadLine().ToLower().Trim();

        bool ehRobo = (resposta == "sim");

        if (!ehRobo)
        {
            Console.WriteLine("Por favor, prove que você não é um robô");
        }
    }
}
