int a;

Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

for (int index = 2; index <= a; index += 2)
{
    if (index % 2 ==0)
        Console.Write($"{index} ");
}