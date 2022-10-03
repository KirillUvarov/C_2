// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [5];

void FillArray(int[] collection) // void - метод, который ничего не возвращает
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 123);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length; // может нужно "col.Length - 1"
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

FillArray(array); 
PrintArray(array);


// int count = 0;
// int count2 = 0;

// for(int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 10 && array[i] < 99)
//     {
//         count++;
//     }
//     else count2++;
// }
// Console.WriteLine();
// Console.WriteLine($"Количество элементов >10 и <99 ->{count}");
// Console.WriteLine($"Количество остальных ->{count2}");
