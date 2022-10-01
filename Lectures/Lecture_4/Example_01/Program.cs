﻿// string[,] table = new string[2, 5];
// // table[0,0]   table[0,1] table[0,2]   table[0,4]
// // table[0,1]


// table[1, 2] = "слово";

// for(int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }


int[,] matrix = new int[3, 4];

void PrintArrayMatrix(int[,] matr) // Метод вывода на консоль матрицы двумерного массива
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


void FillArrayMatrix(int[,] matr) // void - метод, который ничего не возвращает
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(0); j++)
        {
            matr[i, j] = new Random().Next(1, 10); //[1, 10)
        }
    }
}



PrintArrayMatrix(matrix);
FillArrayMatrix(matrix);
Console.WriteLine();
PrintArrayMatrix(matrix);
