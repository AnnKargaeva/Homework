int a;


Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

if (a == 6 || a == 7)
    Console.Write ($"Ура, выходной");

else if (a > 0 && a < 6)
    Console.Write ($"Будний день");
else 
    Console.Write ($"Число не является днём недели");
