int a;


Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

string s = a.ToString();

if (s[0] == s[4] && s[1] == s[3])
    Console.Write($"Число является полиндромом");
else
    Console.Write($"Число не является полиндромом");   