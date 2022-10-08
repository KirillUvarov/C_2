// Программа задаёт массив вещественных чисел и ищет разницу между минимальным и максимальным значениями.

int[] array = new int [5];  // Надо переделать в числах с запятой (дробных)

void FillArray(int[] collection) 
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 100);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("A[");
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
    Console.Write("]");
}

FillArray(array);
PrintArray(array);

int max = 0;
int min = array[0];


for (int i = 0; i  < array.Length; i++)
{    
    if(array[i] > max )      
    {
        max = array[i];
    }
    if(array[i] < min)
    {
       min = array[i]; 
    }
}

Console.WriteLine();
Console.WriteLine($"Максимальное число: {max} ");
Console.WriteLine($"Минимальное число: {min} ");
int difference = max - min;
Console.WriteLine($"Разница: {difference} ");