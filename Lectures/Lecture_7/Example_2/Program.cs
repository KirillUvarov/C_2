﻿// Найти сумму чисел от 1 до n

// int SumFor(int n)
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++) result += 1;
//     Console.WriteLine(result);
//     return result;
// }
// Console.WriteLine(SumFor(10));


int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumRec(10));
