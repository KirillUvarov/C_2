// **Задача 46:** Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.Write("Введите количество    строк матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("                                     Х ");
Console.Write("Введите количество столбцов матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[a, b];

void FillArray(int[,] collection2D)
{
    Random random = new Random();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            collection2D[i, j] = random.Next(0,100); // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
            Console.Write($" {collection2D[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArray(array);
