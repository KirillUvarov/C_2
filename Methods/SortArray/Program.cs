int[] array = { 100, 22, 4, 55, 26, 7, 10, 9, 10, 11 }; // Задаём массив сами

void PrintArray(int[] col) // Заводим метод вывода массива в консоль
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
    Console.WriteLine("");
}

PrintArray(array); // Вызываем метод вывода массива

void SortArray(int[] arr) // Заводим метод сортировки массива от малого к большему
{
    for (int i = 0; i < arr.Length; i++)
    {
        int min = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[min])
            {
                min = j;
            }
        }
        int help = arr[i];
        arr[i] = arr[min];
        arr[min] = help;
        //Console.Write($"{arr[i]} ");
    }
}

SortArray(array); // Вызываем метод сортировки массива от малого к большему
PrintArray(array); // Вызываем метод вывода массива

// Получилось:
// 100 22 4 55 26 7 10 9 10 11 
// 4 7 9 10 10 11 22 26 55 100 
