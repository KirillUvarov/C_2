// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Console.Write("Введите количество    строк матрицы: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("                                     Х ");
// Console.Write("Введите количество столбцов матрицы: ");
// int b = Convert.ToInt32(Console.ReadLine());




//Дурацкий способ:
// double[,] array = new double[5, 5];

// Random random = new Random();
// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         array[i, j] = random.Next(0, 10);
//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine($"++++++++++++");

// Console.WriteLine($"{array[4,0]} {array[4,1]} {array[4,2]} {array[4,3]} {array[4,4]}");
// Console.WriteLine($"{array[1,0]} {array[1,1]} {array[1,2]} {array[1,3]} {array[1,4]}");
// Console.WriteLine($"{array[2,0]} {array[2,1]} {array[2,2]} {array[2,3]} {array[2,4]}");
// Console.WriteLine($"{array[3,0]} {array[3,1]} {array[3,2]} {array[3,3]} {array[3,4]}");
// Console.WriteLine($"{array[0,0]} {array[0,1]} {array[0,2]} {array[0,3]} {array[0,4]}");

int [,] FillAndPrintMatrix (int m, int n)
{
    int [,] array = new int[ m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array [i, j] = new Random().Next(0,10);
            Console.Write($"{array [i,j]}  ");
        }
        Console.WriteLine();
    }
    return array;
}

int [,] CreateNewMatrix (int [,] array)
{ 
    int help = 0;
    int firstString = 0;
    int lastString = array.GetLength(0) -1;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        help = array[firstString, j];
        array[0, j]= array [lastString,j];
        array[lastString,j] = help;
    }
    return array;
}
void PrintNewMatrix (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}


int stringArray = new Random().Next(2,5);
int columnArray = new Random().Next(2,5);
Console.WriteLine($"m = {stringArray}, n = {columnArray}");
Console.WriteLine();
int [,] firstArray = FillAndPrintMatrix(stringArray,columnArray);
int [,] lastArray = CreateNewMatrix(firstArray);
Console.WriteLine();
PrintNewMatrix(lastArray);
