// Принимает число и выдаёт сумму цифр в числе

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (number > 0)
{
   sum = sum + number % 10;
   number = number / 10;
}

Console.WriteLine(sum);