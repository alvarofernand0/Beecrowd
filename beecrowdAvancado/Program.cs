// Beecrowd 1017
using System;

int tempo = int.Parse(Console.ReadLine());
int velocidade = int.Parse(Console.ReadLine());
int consumo = 12;

decimal distanciaPercorrida = tempo * velocidade;

decimal litros = distanciaPercorrida / consumo;

Console.WriteLine($"{litros:f3}");

// Beecrowd 1019
int totalSegundo = int.Parse(Console.ReadLine());

int horas = totalSegundo / 3600;
int minutos = totalSegundo % 3600 / 60;
int segundos  = totalSegundo % 60;

System.Console.WriteLine($"{horas}:{minutos}:{segundos}");





// Beecrowd 1061