using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Deseja cancelar uma operação? (sim/nao): ");
        string resposta = Console.ReadLine().ToLower().Trim();

        bool desejaCancelar = (resposta == "sim");

        if (!desejaCancelar)
        {
            Console.WriteLine("Por favor, confirme o cancelamento da operação");
        }
    }
}
