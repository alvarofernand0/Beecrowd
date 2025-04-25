using System;

class Program
{
    static void Main(string[] args)
    {
        int tempo = int.Parse(Console.ReadLine());
        int velocidade = int.Parse(Console.ReadLine());
        double distancia = (double)velocidade * (double)tempo;
        double litros = distancia / 12;
        Console.WriteLine($"{litros:f3}");
    }
}

