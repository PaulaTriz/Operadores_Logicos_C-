using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        if (!string.IsNullOrEmpty(palavra))
        {
            Console.WriteLine("A palavra não é vazia");
        }
    }
}
