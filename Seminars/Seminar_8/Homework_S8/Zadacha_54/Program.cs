// Задаём двумерный массив. Программа упорядочивает по убыванию элементы каждой строки массива.

Console.WriteLine("Введите размер матрицы");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("X");
int b = Convert.ToInt32(Console.ReadLine());
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

FillArray(array);
PrintArrayMatrix(array);
Console.WriteLine("________");
Console.WriteLine("Упорядочиваем по убыванию элементы каждой строки массива:");
Sort2DArray(array);
PrintArrayMatrix(array);
