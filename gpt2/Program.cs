﻿using System; //Treinando switch case

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número");
        int dia = int.Parse(Console.ReadLine());

        switch (dia)
        {
            case 1: Console.WriteLine("Domingo"); break;
            case 2: Console.WriteLine("Segunda-Feira"); break;
            case 3: Console.WriteLine("Terça-Feira"); break;
            case 4: Console.WriteLine("Quarta-Feira"); break;
            case 5: Console.WriteLine("Quinta-Feira"); break;
            case 6: Console.WriteLine("Sexta-Feira"); break;
            case 7: Console.WriteLine("Sábado"); break;
            default: Console.WriteLine("Não é um dia da semana"); break;
            

        }

    }
}