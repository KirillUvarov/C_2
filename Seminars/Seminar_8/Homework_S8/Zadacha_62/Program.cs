
int a = 4;
int b = 4;

int[,] array = new int[a, b];
int[,] FillAndPrintMatrix(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int r = 0; r <= 16; r++)
            {
                array[i, j] = r;
            }
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    return array;
}
FillAndPrintMatrix(a, b);

// // Random random = new Random();
// for (int i = 0; i < 4; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         a[i, j] = a[i+1, j+1];
//         // a[i, j] = a[0, 0];
//         // i = i + 1;
//         // j = j + 1;
//         Console.Write(array[i, j]);
//     }
//     Console.WriteLine();
// }

// void FillImage(int row, int col)
// {
//     if(pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row-1, col);
//         FillImage(row, col-1);
//         FillImage(row+1, col);
//         FillImage(row, col+1);
//     }
// }

// double [,] a = new
// double[5,10];


// void FillArray(int[,] collection2D)
// {
//     Random random = new Random();
//     for (int i = 0; i < a; i++)
//     {
//         for (int j = 0; j < b; j++)
//         {
//             collection2D[i, j] = random.Next(0,20);
//             Console.Write($" {collection2D[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// FillArray(pic);

// void ImageArrayMatrix(int[,] image) // Метод вывода на консоль матрицы двумерного массива
// {
// for (int i = 0; i < image.GetLength(0); i++)
// {
//     for(int j = 0; j < image.GetLength(1); j++)
//     {
//         //Console.Write($"{image[i, j]} ");
//         if(image[i,j] == 0)  Console.Write($"   ");
//         else Console.Write($"‡");
//     }
//     Console.WriteLine();
// }
// }



// ImageArrayMatrix(pic);
// FillImage(13, 13);
// ImageArrayMatrix(pic);