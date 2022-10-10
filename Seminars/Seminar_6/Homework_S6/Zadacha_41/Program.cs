// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите цифру, соответствующую количеству чисел, которые собераетесь ввести на следующем этапе");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Пошагово введите {m} положительных или отрицательных чисел: ");

int[] array = new int [m];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array [i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0)
    {
        count++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("Ваш массив: A[");
    while (position < count -1)
    {
        Console.Write($"{col[position]}, ");
        position++;
               
    }
    Console.Write($"{col[position]}] ");
}

PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Вы ввели {m} чисел, среди которых {count} положительных");

