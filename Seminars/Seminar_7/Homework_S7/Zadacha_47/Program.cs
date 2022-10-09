// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество    строк матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("                                     Х ");
Console.Write("Введите количество столбцов матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[a, b];

Random random = new Random();
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        array[i, j] = Math.Round(random.NextDouble() * 10 - random.NextDouble() * 10, 2);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

