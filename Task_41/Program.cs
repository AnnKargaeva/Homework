
string[] numbers = Console.ReadLine()!.Split(' ');
int[] array = new int [numbers.Length];

for(int i = 0; i < numbers.Length; i++)

    int.TryParse(numbers[i], out array[i]);
    
int count = 0;
foreach (var i in array)
    if (i > 0)
        count++;

Console.Write($"{count} чисел больше 0");


