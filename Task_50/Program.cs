// Console.WriteLine($"Введите m размерность массива: ");
// int.TryParse(Console.ReadLine(), out m);
// Console.WriteLine($"Введите n размерность массива: ");
// int.TryParse(Console.ReadLine(), out n);

int[ , ] array = new int [4, 4];


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array [i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]}  ");
    }
    Console.WriteLine();
}

int iu, ju;
Console.WriteLine($"Введите позицию элемента в строке: ");
int.TryParse(Console.ReadLine(), out iu);
Console.WriteLine($"Введите позицию элемента в столбце: ");
int.TryParse(Console.ReadLine(), out ju);


if (iu < 0 || iu >= array.GetLength(0))
    Console.Write($"Такое число есть");
else if (ju < 0 || ju >= array.GetLength(0))
    Console.Write($"Такого числа нет");
else 
    Console.Write($"{array[iu, ju]}");
