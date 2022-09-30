// Программа, которая создаёт массив из четырёх элементов трёхзначных чисел и показывает сколько из них чётных. 
int[] array = new int [4];

void FillArray(int[] collection) 
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 1000);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    //Console.Write("A[");
    while (position < count)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
    //Console.Write("]");
}

FillArray(array);
PrintArray(array);

int evenNumber = 0;
for (int i = 0; i  < array.Length; i++)
{    
    if(array[i] % 2 == 0)
    {
        evenNumber++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество чётных элементов: {evenNumber} ");