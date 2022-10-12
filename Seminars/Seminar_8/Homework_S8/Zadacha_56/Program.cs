// Задача 56.
// Ищем строку с наименьшей суммой элементов.

Console.WriteLine("Введите размер квадратной матрицы");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;
Console.WriteLine("________");

int[,] array = new int[a, b];

void FillArray(int[,] collection2D)
{
    Random random = new Random();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            collection2D[i, j] = random.Next(0, 10);
            //Console.Write($" {collection2D[i, j]} ");
        }
        //Console.WriteLine();
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

void SearchMaxSumString(int[,] arr)
{
    for (int z = 0; z < arr.GetLength(0); z++)
    {
        int StringSumMin = z;
        int StringSum1 = 0;
        int StringSum2 = 0;
        for (int q = z + 1; q < arr.GetLength(0); q++) // [z, q]
        {
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                StringSum1 = StringSum1 + arr[z, i];
                StringSum2 = StringSum2 + arr[q, i];
                if (StringSum1 < StringSum2)
                {
                    StringSumMin = z;
                    //Console.WriteLine($"Строка с {arr[z, StringSumMin]} = {StringSum}");
                }
            }


            Console.WriteLine($"Сумма: {StringSum}");
        }
        Console.WriteLine($"Строка: {StringSumMin}");
    }
}

FillArray(array);
PrintArrayMatrix(array);
Console.WriteLine("________");
SearchMaxSumString(array);


// for (int i = 0; i < arr.GetLength(1); i++)
//             {
//                 StringSum = StringSum + arr[z, i];
//                 if (arr[z, i] < arr[StringSumMin, i])
//                 {
//                     StringSumMin = z;
//                     //Console.WriteLine($"Строка с {arr[z, StringSumMin]} = {StringSum}");
//                 }
//             }