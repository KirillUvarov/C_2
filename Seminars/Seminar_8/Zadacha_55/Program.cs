// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] FillAndPrintMatrix(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }

    return array;
}


int[,] CreateArray(int[,] myArray)
{
    int help = 0;
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = i; j < myArray.GetLength(1); j++)
        {
            help = myArray[i, j];
            myArray[i, j] = myArray[j, i];
            myArray[j, i] = help;
        }
    }
    return myArray;
}

void PrintNewMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int stringArray = new Random().Next(2, 5);
int columnArray = new Random().Next(2, 5);
Console.WriteLine($"m = {stringArray}, n = {columnArray}");

Console.WriteLine();
int[,] firstArray = FillAndPrintMatrix(stringArray, columnArray);
if (stringArray != columnArray)
    Console.WriteLine("Невозможно выполнить задание");
else
{
    int[,] lastArray = CreateArray(firstArray);
    Console.WriteLine();
    PrintNewMatrix(lastArray);
}
