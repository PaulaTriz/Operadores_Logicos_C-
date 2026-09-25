using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Deseja comprar um carro novo? (sim/nao): ");
        string querComprar = Console.ReadLine().ToLower().Trim();

        Console.Write("Tem dinheiro suficiente para isso? (sim/nao): ");
        string temDinheiro = Console.ReadLine().ToLower().Trim();

        if (querComprar == "sim" && temDinheiro == "sim")
        {
            Console.WriteLine("Parabens, voce pode comprar um carro novo! ");
        }
    }
}
