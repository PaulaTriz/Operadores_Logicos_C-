using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("É assinante do serviço de streaming? (sim/nao): ");
        string assinante = Console.ReadLine().ToLower().Trim();

        Console.Write("Já assistiu à série específica? (sim/nao): ");
        string assistiu = Console.ReadLine().ToLower().Trim();

        if (assinante == "sim" && assistiu == "sim")
        {
            Console.WriteLine("Otimo, agora voce pode assitir a nova temporada! ");
        }
    }
}
