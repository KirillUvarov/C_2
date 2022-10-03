// **Задача 39:** Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]

// void FAR(int[] mas,int z, int f)
// {
//     int index=0;
//     while (index<mas.Length)
//     {
//         mas[index] = new Random().Next(z, f);
//         index++;
//     }
// }
void Print(int[]mas)
{
    int i=0;
    while (i<mas.Length)
    {
        Console.Write($"{mas[i]} ");
        i++;
    }
}
// Console.Write("Введите размер массива - ");
// int a = Convert.ToInt32(Console.ReadLine());
// int [] arr= new int[a];
// FAR(arr,100,1000);
// Print(arr);
// int help=0;
// int i=0;
// int c=1;
// while (i<arr.Length/2)
// {
//     help=arr[i];
//     arr[i]=arr[arr.Length-c];
//     arr[arr.Length-c]=help;
//     i++;
//     c++;
// }
// Console.WriteLine(" ");
// Print(arr);
