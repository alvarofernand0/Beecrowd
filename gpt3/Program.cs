using System; //Treinando for

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro positivo");
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; (i <= n); i++) 
        {
            Console.WriteLine(i);
        }

    }
}