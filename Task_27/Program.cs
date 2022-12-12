int a;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine(), out a);

int b = a;
int sum = 0;

while (b > 0)
{
    sum += b % 10;
    b /= 10;
}

Console.Write($"{a} -> {sum}");