using System;

class Program
{
    static void Main(string[] args)
    {
        string number = Console.ReadLine();
        int salary = int.Parse(Console.ReadLine());
        double hours = double.Parse(Console.ReadLine());

        Console.WriteLine($"NUMBER = {number}");
        Console.WriteLine($"SALARY = U$ {((double)salary * hours):#0.00}");
    }
}

