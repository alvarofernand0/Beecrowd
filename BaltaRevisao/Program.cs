using System;

class Program
{
    static void Main(string[] args)
    {
        int idade; // Correto inicia com ZERO
        int idade = 25; // Correto inicia com 25
        var idade = 25; // Correto inicia com 25
        var idade; // Errado
        const int IDADE_MINIMA = 25;

        var texto = "Testando";
        Console.WriteLine(texto);

    }
}