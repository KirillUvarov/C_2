// Метод, который создаёт рандомный массив из чисел от -9 до 9 (10 не включается)

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
FillArray(array);