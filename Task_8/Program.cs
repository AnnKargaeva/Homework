int a;

Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

for (int index = 1; index <= a; index ++)
{
    if (index % 2 ==0)
        Console.Write($"{index} ");
}