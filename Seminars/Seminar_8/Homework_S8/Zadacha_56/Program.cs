// Задача 56.
// Ищем строку с наименьшей суммой элементов.

Console.Write("Введите количество строк в квадратной матрице: ");
int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите количество столбцов в матрице: ");
int b = a; //Convert.ToInt32(Console.ReadLine());
int[,] array = new int[a, b];


void FillArray2D(int[,] collection2D)
{
    Random random = new Random();
    for (int i = 0; i < collection2D.GetLength(0); i++)
    {
        for (int j = 0; j < collection2D.GetLength(1); j++)
        {
            collection2D[i, j] = random.Next(0, 100);
        }

    }
}

void PrintArrayMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MinStringSum(int[,] arr)
{
    int MinStringSum = int.MaxValue;
    int indexMinString = 0;
    for (int i = 0; i < a; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < b; j++)
            rowSum += arr[i, j];

        if (rowSum < MinStringSum)
        {
            MinStringSum = rowSum;
            indexMinString = i;

        }

    }

    Console.WriteLine("Строка с минимальной суммой элементов");
    for (int j = 0; j < b; j++)
    {
        Console.Write(array[indexMinString, j] + " ");
    }
}

FillArray2D(array);
PrintArrayMatrix(array);
MinStringSum(array);







