
System.Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());
bool primo = true;
int divisao = 0;

for (int i = 2; i < numero; i++)
{
    if (numero % i == 0)
    {
        primo = false;
        break;
    }
}

