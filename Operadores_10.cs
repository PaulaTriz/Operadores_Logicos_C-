using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 10 || numero < 0)
        {
            Console.WriteLine("Número inválido!");
        }
    }
}