using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 3 == 0 || numero % 5 == 0)
        {
            Console.WriteLine("O número é divisível por 3 ou por 5!");
        }
    }
}