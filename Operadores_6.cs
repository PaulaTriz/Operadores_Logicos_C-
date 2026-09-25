using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Deseja adicionar açúcar? (sim/nao): ");
        string acucar = Console.ReadLine().ToLower().Trim();

        Console.Write("Deseja adicionar leite? (sim/nao): ");
        string leite = Console.ReadLine().ToLower().Trim();

        if (acucar == "sim" || leite == "sim")
        {
            Console.WriteLine("Cafe com adicional preparado!");
        }
    }
}
