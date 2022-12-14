double [] array = new double [4];
for (int i = 0; i < array.Length; i++)
{ 
    array [i] = new Random().Next(1000) / 100.0;
    Console.Write($"{array[i]}   ");
}
Console.WriteLine();

double min = array[0];
double max = array[0];
for (int i = 0; i < array.Length; i++)
    if (array[i] < min)
        min = array[i];
    else if (array[i] > max)
        max = array[i];


Console.WriteLine($"Разница max и min ->  {max-min}");