// Принимает 8 чисел, задаёт из них массив элементов и выводит на экран

int[] array;
int n = 8;
array = new int [n];
for (int i = 0; i < n; i++)
{
    Console.Write("A[{0}]= ", i);
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write($"A[{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}]");