// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит 
// информацию о том, сколько раз встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

// int [,] array = new int [5, 5];

// int a = 0;
// int b = 1;
// int c = 2;
// int d = 3;
// int e = 4;
// int f = 5;
// int g = 6;
// int h = 7;
// int k = 8;
// int l = 9;

// Random random = new Random();
// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         array[i, j] = random.Next(0, 10);
//         Console.Write($"{array[i, j]} ");
//     }
//     for (int count = 0; count < array.LongLength; count++)
//     {
//         if (i == a) //|| i == b )
//         {
//             count ++;
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine(count);
// }
// Console.WriteLine($"++++++++++++");


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

void SearchNumbers(int[,] array)
{

    for (int number = 0; number < 10; number++)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (number == array[i, j])
                    count++;
            }
        }
        if ( count != 0)
        
        Console.WriteLine($"{number} встречается {count} раз");
    }
}

int stringArray = new Random().Next(2,5);
int columnArray = new Random().Next(2,5);
Console.WriteLine($"m = {stringArray}, n = {columnArray}");

Console.WriteLine();
int [,] Array = FillAndPrintMatrix(stringArray,columnArray);
SearchNumbers(Array);
