//Метод вывода массива в терминал

int[] array = new int [5];

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
PrintArray(array);