// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.  45 -> 101101  3 -> 11  2 -> 10
Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
string y ="";

while(x > 0)
{
    y = Convert.ToString(x % 2) + y;
    x /= 2;
}
Console.WriteLine($"{y}");