// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


//Console.Write("Введите количество символов в массиве: "); // Вводим 8
int length = 8; //Convert.ToInt32(Console.ReadLine());
int[] array = new int [8]; //int[] array = new int [length];
int index = 0;

while(index < 8) //while(index < length)
{
    array[index] = new Random().Next(0,2);
    index++;
}
for(int i = 0; i < length; i++)
{
    Console.Write($"{array[i]} ");
}