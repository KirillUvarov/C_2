// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = new int [123];

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

int count = 0;
int count2 = 0;

for(int i = 0; i < array.Length; i++)
{
    if (array[i] > 10 && array[i] < 99)
    {
        count++;
    }
    else count2++;
}
Console.WriteLine();
Console.WriteLine($"Количество элементов >10 и <99 ->{count}");
Console.WriteLine($"Количество остальных ->{count2}");
