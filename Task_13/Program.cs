int a;


Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

if (a < 100)
{
    Console.Write ($"Третьей цифры нет");
}
else 
{
    int b = a;
    while (b / 100 >= 10)
    b /= 10;
    Console.Write ($"{a} -> {b % 10}");
}