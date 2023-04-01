// Receba uma medida em milhas e exiba seu equivalente em quilômetros. A medida em km é 1,609 vezes a medida em milhas.

double milhas;
double Km;

Console.WriteLine("----Conversor de minhas----\n");

Console.Write("Digite a medida em Minhas: ");
milhas = double.Parse(Console.ReadLine()!);

Km = milhas * 1.609;

Console.WriteLine($"{milhas} minhas equivalem a {Km} quilômetros.");
Console.ReadLine();

