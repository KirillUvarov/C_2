// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите   количество  строк матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("                                     Х ");
Console.Write("Введите количество столбцов матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[a, b];

Random random = new Random();
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        array[i, j] = random.Next(0, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("===============");

double sum = 0;
for (int j = 0; j <= b - 1; j++)
{
    for (int i = 0; i <= a - 1; i++)
    {
        sum = array[i,j] + sum;
    }
    double ArithmeticMean = sum / a;
    Console.Write($"{Math.Round(ArithmeticMean, 1)}; ");
}