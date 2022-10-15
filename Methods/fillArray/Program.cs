// Метод, который создаёт рандомный массив из чисел от -9 до 9 (10 не включается)

// int[] array = new int [5];

// void FillArray(int[] collection) // void - метод, который ничего не возвращает
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(-9,10);
//         index++;
//     }
// }
// FillArray(array);





// int[,] array = new int [13,13];

// void FillArray(int[,] collection) // void - метод, который ничего не возвращает
// {
//     int length = collection.Length;
//     int index = 0;
//     int index2 = 0;
//     while (index < length && index2 < length)
//     {
//         collection[index,index2] = new Random().Next(-9,10);
//         index++;
//     }
// }
// FillArray(array);

// Console.WriteLine(array);

int[,] pic = new int[13, 13];
void FillArray(int[,] collection2D)
{
    Random random = new Random();
    for (int i = 0; i < 13; i++)
    {
        for (int j = 0; j < 13; j++)
        {
            collection2D[i, j] = random.Next(0,2); // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
            Console.Write($" {collection2D[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArray(pic);
Console.WriteLine(pic);
