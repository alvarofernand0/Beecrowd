using System;

class Program
{
    static void Main(string[] args)
    {
        MeuMetodo();

        string nome = RetornaNome("Antonio ", "Nunes ", 32);
        Console.WriteLine(nome);
    }
    static void MeuMetodo()
    {
        Console.WriteLine("Algum texto Aqui");
    }

    static string RetornaNome(
        string nome,
        string sobrenome,
        int idade)
    {
        return nome + sobrenome + "tem " + idade.ToString();
    }
}