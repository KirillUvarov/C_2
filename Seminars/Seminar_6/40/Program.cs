// Задача 40.
// Программа, которая принимает три числа и проверяет, может ли существовать треугольник с такими сторонами

Console.WriteLine("Введите три числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a+b>c && b+c>a && a+c>b)
{
   Console.Write("Треугольник возможен"); 
}
else 
{
    Console.Write("Треугольник НЕвозможен");
}

// int count=0;
// int z=a;
// int b = 0;

// void Print(int[]mas)
// {
//     int i=0;
//     while (i<mas.Length)
//     {
//         Console.Write($"{mas[i]} ");
//         i++;
//     }
// }

// while (a>0)
// {
//     b=a%2;
//     a=a/2;
//     // Console.Write($"{b} ");
//     count++;
// }
// int [] arr= new int[count];
// int j=1;
// while (z>0)
// {
//     arr[count-j]=z%2;
//     z=z/2;
//     j++;
// }
//  Console.WriteLine(" ");

// Print(arr);
