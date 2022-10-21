// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// A(m,n) = {n+1, A(m-1, 1), A(m-1, A(m, n-1))} 
// https://ru.wikipedia.org/wiki/%D0%A4%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F_%D0%90%D0%BA%D0%BA%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B0


Console.Write("Введите начальное число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальное число n:");
int n = Convert.ToInt32(Console.ReadLine());

int AckermanFun(int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return AckermanFun(M - 1, 1);
    if (M > 0 && N > 0) return AckermanFun(M - 1, AckermanFun(M, N - 1));
    return AckermanFun(M, N);
}

Console.WriteLine($"A({m},{n}) = {AckermanFun(m, n)}");