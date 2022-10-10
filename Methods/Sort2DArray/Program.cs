int[,] array = new int[,]
{
{11, 19, 12, 17, 16},
{21, 23, 25, 24, 22},
{31, 33, 35, 34, 32},
{41, 44, 47, 46, 42},
{58, 54, 55, 57, 59},
};

PrintArrayMatrix(array);
Console.WriteLine("============");

void Sort2DArray(int[,] arr) // Заводим метод сортировки массива от малого к большему
{
    for (int z = 0; z < arr.GetLength(0); z++)
    {

        for (int i = 0; i < arr.GetLength(1); i++)
        {
            int max = i;

            for (int j = i + 1; j < arr.GetLength(1); j++)
            {

                if (arr[z, j] > arr[z, max])
                {
                    max = j;
                }

            }

            int help = arr[z, i];
            arr[z, i] = arr[z, max];
            arr[z, max] = help;
        }

    }
}

Sort2DArray(array);

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

PrintArrayMatrix(array);