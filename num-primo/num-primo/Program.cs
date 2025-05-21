using System;

class Program
{
    static void Main()
    {
        System.Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
        int divisores = 0;

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                divisores++;
            }
        }
        if (divisores == 2)
        {
            System.Console.WriteLine($"{numero} É Primo");
        }
        else
        {
            System.Console.WriteLine($"{numero} Não é Primo");
        }
    }
}


