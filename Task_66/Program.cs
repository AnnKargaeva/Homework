int m = 1, n = 10;
Console.Write($"{Summ(n, 1)}");

string Summ(int left, int right)
{
    if (left >= right)
        return left;
    return left + Summ(left + 1, right);
}