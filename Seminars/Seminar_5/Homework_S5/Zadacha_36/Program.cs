// Программа, которая создаёт массив из восьми элементов от -100 до +100 и считает сумму элементов на нечётных позициях
int[] array = new int [8];

void FillArray(int[] collection) 
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-100, 100);
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

int evenNumberSum = 0;
for (int i = 0; i  < array.Length; i++)
{    
    if(i % 2 != 0)      // != - знак неравенства
    {
        evenNumberSum = evenNumberSum + array[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма нечётных элементов: {evenNumberSum} ");