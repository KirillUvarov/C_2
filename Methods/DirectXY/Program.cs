Console.WriteLine("Для определения, в какой точке на графике пересекаются прямые, ");
Console.Write("введите значение первой прямой b1=");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение первой прямой k1=");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение второй прямой b2=");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение второй прямой k2=");
double k2 = Convert.ToInt32(Console.ReadLine());

double DirectXY(double k, double b, double x) // Метод, в котором принимается два значения из формулы и X и возвращается Y
{
    double y = k * x + b; // Уравнение построения прямой на графике
    return y;
}

Console.Write($"{ХDirectXY(k1, b1, 10)}"); // Выводит координаты точки на оси Y при X = 10 на прямой

// уравнение окружности (радиус 5) x^{2}+y^{2} = 5  
//\left(x^{2}+y^{2}\right)^{2}=5\left(x^{2}-y^{2}\right)
// https://matematikam.ru/calculate-online/grafik.php - визуализация графика