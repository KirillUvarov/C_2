// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите   количество  строк матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("                                     Х ");
Console.Write("Введите количество столбцов матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[a, b];

Random random = new Random();
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        array[i, j] = random.Next(0, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Console.Write("Введите позицию возвращаемого числа: ");
int c = Convert.ToInt32(Console.ReadLine());
if (c <= a*b)
{
    Console.Write($"{array[c/a,(c%a)-1]}");
}
else
Console.Write("Такого числа в массиве нет");