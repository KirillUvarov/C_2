// Двумерные массивы

// int[] x = new int[] {1, 2, 3, 4, 5}; //Это одномерный массив

// int[,] xx = new int[] {{1, 2, 3, 4, 5}, // Это двумерный массив
//                     {1, 2, 3, 4, 5}};

// int[,] x;
// int[,] x = new int[2, 5] {{1, 2, 3, 4, 5}, 
//                     {1, 2, 3, 4, 5}};


// int[,] xx = {{1, 2, 3, 4, 5}, // Это двумерный массив
//                     {1, 2, 3, 4, 5}, 
//                     {1, 2, 3, 4, 5}};

// for(int i = 0; i < xx.GetLength(0); i++); // 0 = 2, 1 = 5 
// {
//     for (int j = 0; j < xx.GetLength(1); j++);
//     {
//         Console.Write($"{xx[i, j]}");
//     }
//     Console.WriteLine();
// }

int a = -15;
int b = 2;
int c = -10;
int d = 1;

int SummaChisel(int x, int y)
{
    int sum = x + y;
    return sum;
}

int sum1 = SummaChisel(a, b);
int sum2 = SummaChisel(c, d);

// int DifEr(int nomer1, int nomer2)
// {
//     while (nomer1 != nomer2)
//     {
//         nomer1 = SummaChisel(a, b);
//         a++;
//         nomer2 = SummaChisel(c, d);
//         c++;
//         // Console.Write($"{nomer1} | ");
//         // Console.WriteLine($"{nomer2}");
//     }
//     return nomer1;
// }   

if (sum1 == sum2)
{
    Console.WriteLine($"-{sum1}-");
}

// Console.WriteLine(sum1); // Подставляем вместо x -> a, y -> b 
// Console.WriteLine(sum2);