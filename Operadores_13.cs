using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Você é um membro inativo do clube? (sim/nao): ");
        string resposta = Console.ReadLine().ToLower().Trim();

        bool inativo = (resposta == "sim");

        if (!inativo)
        {
            Console.WriteLine("Por favor, atualize sua inscrição para continuar usufruindo dos benefícios do clube");
        }
    }
}