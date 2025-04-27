using System; //Treinando if, else e else if

class Program
{
    static void Main(string[] args)
    {
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine($"Seu número é {numero}");

        if (numero > 0)
        {
            Console.WriteLine("Seu número é Positivo");
        }
        else if (numero < 0)
        {
            Console.WriteLine("Seu número é Negativo");
        }
        else if (numero == 0)
        {
            Console.WriteLine("Seu número é zero");

        }
        else
        {
            Console.WriteLine("Fim do programa");

        }
    }
}
