int a, b;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine(), out a);
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine(), out b);

if (b == 0)
    Console.Write(1);
else
{
    int ans = a;
    for (int i = 1; i < b; i++)
        ans *=a;
    Console.WriteLine(ans);
}