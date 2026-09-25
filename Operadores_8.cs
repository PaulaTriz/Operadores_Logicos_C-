using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Deseja comprar um produto? (sim/s/nao): ");
        string resposta = Console.ReadLine().ToLower().Trim();

        if (resposta == "sim" || resposta == "s")
        {
            Console.WriteLine("Obrigado pela compra!");
        }
    }
}
