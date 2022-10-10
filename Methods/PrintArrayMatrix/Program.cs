int[,] matrix = new int[3, 4];

// Метод вывода на консоль матрицы двумерного массива

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

PrintArrayMatrix(matrix);