// Метод, вычисляющий корень степени n из числа x

void TheRootOfNdegree(int n, double x) // n - степень, x - из чего извлекаем корень
{

    Console.Write("Enter a number to extract the root: "); //Console.Write("Введите число для извлечения корня: ");
    x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter the degree of the extracted root: "); // Console.Write("Введите степень корня: "); 
    n = Convert.ToInt32(Console.ReadLine());//степень
    double s = Math.Pow((double)x, (double)1 / n);
    Console.WriteLine($"The root of the {n} degree of {x} = {s}"); // Console.WriteLine($"Корень {n}й степени из {x} = {s}");
    //Console.ReadKey(true); // Если включить, то консоль будет ждать нажатия на enter для завершения задачи
}

TheRootOfNdegree(5, 6);

// Преобразовано из:
// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         // int n = 5;//степень
//         Console.Write("Enter a number to extract the root: "); //Console.Write("Введите число для извлечения корня: ");
//         double x = Convert.ToDouble(Console.ReadLine());
//         Console.Write("Enter the degree of the extracted root: "); // Console.Write("Введите степень корня: "); 
//         int n = Convert.ToInt32(Console.ReadLine());//степень
//         double s = Math.Pow((double)x, (double)1 / n);
//         Console.WriteLine($"The root of the {n} degree of {x} = {s}"); // Console.WriteLine($"Корень {n}й степени из {x} = {s}");
//         //Console.ReadKey(true);
//     }
// }