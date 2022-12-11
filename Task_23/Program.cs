int a;

Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

for (int i = 1; i <= a; i++)
    Console.Write($"{i * i * i} ");
