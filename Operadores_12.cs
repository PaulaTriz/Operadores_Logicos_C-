using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        double numero = double.Parse(Console.ReadLine());

        if (numero != 0)
        {
            Console.WriteLine("O número é diferente de zero");
        }
    }
}