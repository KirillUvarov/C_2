// // Необходимо найти  5 целых чисел (положительных), которые будут удовлетворять такому условию
// // x^5 + y^5 + z^5 + q^5 = w^5
// // Т.е. сумма 4 чисел в пятой степени = 5 числу

// // double[] array = new double[4];

// void TheRootOfNdegree(int n, double x) // n - степень, x - из чего извлекаем корень
// {
//     //Console.Write("Enter a number to extract the root: "); //Console.Write("Введите число для извлечения корня: ");
//     //x = Convert.ToDouble(Console.ReadLine());
//     //Console.Write("Enter the degree of the extracted root: "); // Console.Write("Введите степень корня: "); 
//     //n = Convert.ToInt32(Console.ReadLine());//степень
//     double s = Math.Pow((double)x, (double)1 / n);
//     Console.WriteLine($"The root of the {n} degree of {x} = {s}"); // Console.WriteLine($"Корень {n}й степени из {x} = {s}");
//     //Console.ReadKey(true); // Если включить, то консоль будет ждать нажатия на enter для завершения задачи
// }


// double w = Convert.ToInt32(Console.ReadLine());
// double n = Convert.ToInt32(Console.ReadLine());
// // Для корня 5 степени первое слагаемое в разложении находится по правилу n^4-(n-1)
// double W = Math.Pow(w, n);
// Console.WriteLine($"{w},{W}");

Console.Write("Что будем возводить?: ");
int w = Convert.ToInt32(Console.ReadLine());
Console.Write("В какую степень?: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{w}^{n} = {(long)Math.Pow(w, n):N0} (0x{(long)Math.Pow(w, n):X})");



   
// int IntPow(int x, uint pow)
// {
//     int ret = 1;
//     while ( pow != 0 )
//     {
//         if ( (pow & 1) == 1 )
//             ret *= x;
//         x *= x;
//         pow >>= 1;
//     }
//     return ret;
// }
// IntPow(2, 5);












// double x = 2;
// double y = 2;
// double z = 2;
// double q = 2;
// double W = Math.Pow(w, 5); 
// double X = Math.Pow(x, 5);
// double Y = Math.Pow(y, 5);
// double Z = Math.Pow(z, 5);
// double Q = Math.Pow(q, 5);
// double sum = X + Y + Z + Q;
// int sm = x + y + z + q;

// while (sum != W)
// {
//     x = new Random().Next(0, 200);
//     y = new Random().Next(0, 200);
//     z = new Random().Next(0, 200);
//     q = new Random().Next(0, 200);

// }
// Console.WriteLine($"{w}, {x}, {y}, {z}, {q}");
// else
// {
//     Console.WriteLine(sum);
// }



// double W = 0;
// double X = 0;
// double Y = 0;
// double Z = 0;
// double Q = 0;

// if (W == X + Y + Z + Q)
// {
//     Console.WriteLine($"{w}, {x}, {y}, {z}, {q}");
// }
// else
// {
//     w = new Random().Next(0, 200);
//     x = new Random().Next(0, 200);
//     y = new Random().Next(0, 200);
//     z = new Random().Next(0, 200);
//     q = new Random().Next(0, 200);
// }

// while (W != X + Y + Z + Q)
// {
//     w = new Random().Next(0, 200);
//     x = new Random().Next(0, 200);
//     y = new Random().Next(0, 200);
//     z = new Random().Next(0, 200);
//     q = new Random().Next(0, 200);

//     W = Math.Pow(w, 5);
//     X = Math.Pow(x, 5);
//     Y = Math.Pow(y, 5);
//     Z = Math.Pow(z, 5);
//     Q = Math.Pow(q, 5);
// }

// Console.WriteLine($"{w}, {x}, {y}, {z}, {q}");

// // void FillArray(double[] collection)
// // {
// //     double length = collection.Length;
// //     double index = 0;
// //     while (index < length)
// //     {
// //         collection[index] = new Random().Next(0, 200);
// //         index++;
// //     }
// // }
// // FillArray(array);

// // // 1 + 2 + 3 + 4 = 10

// // while (index < 200)
// // {

// // }

// //array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100; // Сгенерировали целое число !!!



