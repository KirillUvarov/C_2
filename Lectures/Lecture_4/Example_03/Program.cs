// Факториал

double Factorial(int n) // int заменили на double
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n-1);

}

// Console.WriteLine(Factorial(3)); // 3! = 1 * 2 * 3 = 6
// Console.WriteLine(Factorial(20)); // 20! = -2102132736
// Console.WriteLine(); // Пустая строка

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
