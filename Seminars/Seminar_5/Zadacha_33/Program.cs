// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> НЕТ
// -3; массив [6, 7, 19, 345, 3] -> ДА

int[] array = new int [5];

void FillArray(int[] collection) // void - метод, который ничего не возвращает
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-9,10);
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

FillArray(array); 

int find = 4;

PrintArray(array);

int position = -1;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == find)
    {
        position = i;
    }
    
}

if (position > 0)
    {
        Console.WriteLine("ДА");
    }
else
Console.WriteLine("НЕТ");