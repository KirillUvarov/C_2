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

FillArray(array);
PrintArrayMatrix(array);

void SumString2DArray(int[,] arr)
{
    for (int z = 0; z < arr.GetLength(0); z++)
    {
        int StringSum = 0;
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            //int StringSumMin = i;
            
            StringSum = StringSum + arr[z,i];
            

            // for (int j = i + 1; j < arr.GetLength(1); j++)
            // {
            //     StringSum = StringSum + arr[z,j];
            // }

            // int help = arr[z, i];
            // arr[z, i] = arr[z, max];
            // arr[z, max] = help;
        }
        Console.WriteLine($"{StringSum}");

    }
}

