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
Console.WriteLine();


for (int a = 0; a < array.GetLength(0); a++)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int k = array [a, i];
        int j = i - 1;

        while (j >= 0 && array [a, j] < k)
        {
            array[a, j+1] = array [a, j];
            array [a, j] = k;
            j--;
        }
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
                Console.Write($"{array[i, j]}  ");
    }
    Console.WriteLine();
}