// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями 
//y = k1 * x + b1, 
//y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите координату X первой точки ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки ");
int k2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y второй точки ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z второй точки ");
// int z2 = Convert.ToInt32(Console.ReadLine());

double y = 0;
double x = 0;
y = k1 * x + b1;
y = k2 * x + b2; // Math.Sqrt - извлечение корня
y = Math.Round(d,2); // округление до 2х символов после запятой
Console.WriteLine(d);
//Math.Pow(d,2); - возведение в степень