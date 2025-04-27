using System; //Treinando for + if, else juntos

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro positivo");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 0; i <= numero; i++)
        {

            if (i % 2 == 0)
            {
                Console.WriteLine(i);

            }
            else {
                Console.WriteLine("");
            }


        }
}   }