using System;
class Program
{
    static void Main(string[] args)
    {
        int valor = int.Parse(Console.ReadLine());
        Console.WriteLine(valor);

        int notasDe100 = valor / 100;
        valor = valor - notasDe100 * 100;
        Console.WriteLine($"{notasDe100} nota(s) de R$ 100,00");

        int notasDe50 = valor / 50;
        valor = valor - notasDe50 * 50;
        Console.WriteLine($"{notasDe50} nota(s) de R$ 50,00");

        int notasDe20 = valor / 20;
        valor = valor - notasDe20 * 20;
        Console.WriteLine($"{notasDe20} nota(s) de R$ 20,00");

        int notasDe10 = valor / 10;
        valor = valor - notasDe10 * 10;
        Console.WriteLine($"{notasDe10} nota(s) de R$ 10,00");

        int notasDe5 = valor / 5;
        valor = valor - notasDe5 * 5;
        Console.WriteLine($"{notasDe5} nota(s) de R$ 5,00");

        int notasDe2 = valor / 2;
        valor = valor - notasDe2 * 2;
        Console.WriteLine($"{notasDe2} nota(s) de R$ 2,00");

        int notasDe1 = valor / 1;
        valor = valor - notasDe1 * 1;
        Console.WriteLine($"{notasDe1} nota(s) de R$ 1,00");

    }
}