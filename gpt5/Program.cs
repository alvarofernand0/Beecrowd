// Treino de while

using System;


class Program
{
    static void Main(string[] args)
    {
       
        int soma = 0;
        int opcao;
        do
        {
            Console.WriteLine("Digite um número");
            opcao = int.Parse(Console.ReadLine());
            soma += opcao;


        }while (opcao != 0);

        Console.WriteLine($"A soma é {soma}");
        Console.ReadKey();
    }
}