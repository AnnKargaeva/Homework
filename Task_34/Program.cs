int [] array = new int [4];
for (int i = 0; i < array.Length; i++)
{ 
    array [i] = new Random().Next(99, 1000);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

int count = 0;
for (int i = 0; i < array.Length; i++)
    if ( array[i] % 2 == 0)
        count++;
Console.WriteLine($"Количество четных чисел в массиве: {count}");
