using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        if (nome.Length > 3 && idade >= 18)
        {
            Console.WriteLine("Acesso permitido");
        } else
        {
            Console.WriteLine("Acesso negado");
        }
    }
}
