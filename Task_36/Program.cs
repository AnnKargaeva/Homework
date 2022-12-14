int [] array = new int [4];
for (int i = 0; i < array.Length; i++)
{ 
    array [i] = new Random().Next(-100, 100);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

int sum = 0;
for (int i = 0; i < array.Length; i++)
    if (i % 2 != 0)
        sum = sum + array[i];
Console.WriteLine($"Сумма элементов нечетных индексов: {sum}");