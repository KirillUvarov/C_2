// Рекурсия. Возведение в степень.

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result = result * a;
    return result;
}
Console.WriteLine(PowerFor(2, 10));

int PowerRec(int a, int n)
{
    // return n == 0 ? : PowerRec(a, n -1) * a;
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}
Console.WriteLine(PowerRec(2, 10));