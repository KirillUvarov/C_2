int[,] matrix = new int[3, 4];

// Метод вывода на консоль матрицы двумерного массива

void PrintArrayMatrix(int[,] matr) 
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
}

PrintArrayMatrix(matrix);