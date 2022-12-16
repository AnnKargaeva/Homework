int m, n;
Console.WriteLine($"Введите m размерность массива: ");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine($"Введите n размерность массива: ");
int.TryParse(Console.ReadLine(), out n);

int[ , ] array = new int [m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array [i, j] = new Random().Next(-10, 10);
        Console.Write($"{array[i, j]}  ");
    }
    Console.WriteLine();
}