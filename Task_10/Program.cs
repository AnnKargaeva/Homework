int a;


Console.Write($"Введите 3х значное число: ");
int.TryParse(Console.ReadLine()!, out a);

Console.Write($"{a} -> {a / 10 % 10}");