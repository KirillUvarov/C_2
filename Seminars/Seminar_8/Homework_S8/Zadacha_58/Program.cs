// Задача 58.
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Введите количество строк двух матриц: ");
int a = Convert.ToInt32(Console.ReadLine());
int c = a;
Console.Write("Введите количество столбцов двух матриц: ");
int b = Convert.ToInt32(Console.ReadLine());
int d = b;
int[,] array1 = new int[a, b];
int[,] array2 = new int[c, d];

void FillArray(int[,] collection2D)
{
    Random random = new Random();
    //int sumString = 0;
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            collection2D[i, j] = random.Next(0, 10);
            //sumString = sumString + collection2D[i, j];
            // Console.Write($" {collection2D[i, j]}");
        }
        //Console.WriteLine($"||{sumString}");
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

void Multi2Matrix(int[,] arr1, int[,] arr2)
{
    Console.WriteLine("Перемноженная матрица: ");
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            Console.Write(array1[i, j] * array2[i, j] + " ");
        }
        Console.WriteLine();
    }
}

FillArray(array1);
FillArray(array2);
PrintArrayMatrix(array1);
Console.WriteLine("________");
PrintArrayMatrix(array2);
Console.WriteLine("________");
Multi2Matrix(array1, array2);


// Console.WriteLine("Введите размер двух матриц");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("________");
// int c = a;
// int d = b;

// int[,] array1 = new int[a, b];
// int[,] array2 = new int[c, d];





// void FillArrayM(int[] collection, int t) // void - метод, который ничего не возвращает
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = t;
//         index++;
//     }
// }
// //FillArray(array);
// int[,] arrayM = new int[a, b];

// int[,] Multiplication(int[,] a, int[,] b)
// {
//     int[,] r = new int[a.GetLength(0), b.GetLength(1)];
//     for (int i = 0; i < a.GetLength(0); i++)
//     {
//         for (int j = 0; j < b.GetLength(1); j++)
//         {
//             for (int k = 0; k < b.GetLength(0); k++)
//             {
//                 r[i, j] = a[i, k] * b[k, j];
//                 Console.Write($"{r} ");
//             }
//             Console.WriteLine();
//         }
//     }
//     return r;

// }
// Console.WriteLine("________");
// Multiplication(array1,array2);

// int[,,] array = new int[3, 3, 3];
// Random random = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int k = 0; k < array.GetLength(2); k++)
//         {
//             array[i, j, k] = array[{random.Next(10, 20)}, j++, k++]; //random.Next(10, 20) + random.Next(10, 20);

//             // i = random.Next(10, 20);
//             // j = random.Next(21, 30);
//             // k = random.Next(31, 40);
//             Console.Write($"{array[i, j, k]}|");
//         }
//         Console.WriteLine();
//     }
// }