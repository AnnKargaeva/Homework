int[ , , ] array = new int [2, 2, 2];

int [ ] array1 = new int[90];

for (int i = 0; i < 90; i++)
    array1[i] = i + 10;


for (int i = 0; i < array.GetLength(0); i++)

{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            int temp = new Random().Next(90);
            while (array1[temp] == 0)
                temp = new Random().Next(90);
            array [i, j, k] = array1[temp];
            array1[temp] = 0;
            
        }
    }
}

for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
            Console.Write($"{array[i, j, k]}({i}, {j}, {k})  ");
        Console.WriteLine();
    }
