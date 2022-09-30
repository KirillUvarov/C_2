// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = new int [4];

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


for (int i = 0; i  < array.Length; i++)
{
    array[i] = - array[i];
}
    
Console.WriteLine();
PrintArray(array);

// for (int i = 0; i  < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         array[i] = - array[i];// * -1;
//     }
//     else
//     {
//         sum2 = sum2 + array[i];
//     }
// }