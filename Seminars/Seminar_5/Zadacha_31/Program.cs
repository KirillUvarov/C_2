// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int length = 12; //Convert.ToInt32(Console.ReadLine());
int[] array = new int [12]; //int[] array = new int [length];
// int index = 0;

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

PrintArray(array);

int sum1 = 0;
int sum2 = 0;

for (int i = 0; i  < array.Length; i++)
{
    if (array[i] > 0)
    {
        sum1 = sum1 + array[i];
    }
    else
    {
        sum2 = sum2 + array[i];
    }
}
Console.WriteLine();
Console.WriteLine(sum1);
Console.WriteLine(sum2);