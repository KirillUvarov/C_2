//Возведение заданного числа в заданную степень 
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень возведения: ");
int value = Convert.ToInt32(Console.ReadLine());
int count = 0;
int result = 1;

while (count < value)
{
    result = result * number;
    count++;
    }
Console.WriteLine(result);