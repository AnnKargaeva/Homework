// Console.WriteLine($"Введите m размерность массива: ");
// int.TryParse(Console.ReadLine(), out m);
// Console.WriteLine($"Введите n размерность массива: ");
// int.TryParse(Console.ReadLine(), out n);

int[ , ] array = new int [4, 4];
int m;
Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine(), out m);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array [i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]}  ");
    }
    Console.WriteLine();
}
bool find = false;

foreach (var i in array)
    if (m == i) 
    {
        find = true; 
        break;
    }
if (find)
    Console.Write($"Такое число есть");
else
    Console.Write($"Такого числа нет");
