// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// //заданных уравнениями 
// //y = k1 * x + b1, 
// //y = k2 * x + b2; 
// //значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Для определения, в какой точке на графике пересекаются прямые, ");
Console.Write("введите значение первой прямой b1=");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение первой прямой k1=");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение второй прямой b2=");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение второй прямой k2=");
double k2 = Convert.ToInt32(Console.ReadLine());

double DirectXY(double k, double b, double x) // Метод, в котором принимается два значения и X и возвращается Y
{
    double y = k * x + b; // Функция построения прямой на графике
    return y;
}

if (k1 != k2)
{
    double x = -10; // Стартуем перебор X со значения -10
    while (x <= 10) // Выполняем перебор точек от -10 до +10 на оси абсцисс 
    {
        double y1 = DirectXY(k1, b1, x);
        double y2 = DirectXY(k2, b2, x);

        if (y1 == y2)
        {
            Console.Write($"Пересечение в координатах: (X = {Math.Round(x, 2)} :");
            Console.WriteLine($"Y =  {Math.Round(y1, 2)})");
            break;
        }
        else
        {
            x = x + 0.5;
        }
    }

}
else if (b1 == b2)
{
    Console.Write($"Прямые совпадают");
}
else
{
    Console.Write($"Прямые параллельны");
}





