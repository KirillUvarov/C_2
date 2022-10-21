// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

void betweenSum (int a, int b, int Sum)
{
    if (a > b) 
    {
        Console.WriteLine($"Сумма чисел в промежутке от M до N = {Sum}"); 
        return;
    }
    Sum = Sum + (a++);
    betweenSum(a, b, Sum);
}

betweenSum(M, N, 0);