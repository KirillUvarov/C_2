// **Задача 51:** Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


Console.Write("Введите количество    строк матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("                                     Х ");
Console.Write("Введите количество столбцов матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[a, b];
int SumDiag = 0;

void FillArray(int[,] collection2D)
{
    Random random = new Random();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            collection2D[i, j] = random.Next(0, 100); // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
            Console.Write($" {collection2D[i, j]} ");
            if (i == j)
            {
                SumDiag = SumDiag + array[i, j];
            }
        }
    }
    Console.WriteLine();

}

FillArray(array);
