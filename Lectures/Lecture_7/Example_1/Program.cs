// Рекурсия

string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i}";
    }
    return result;
}

// string NumbersRec(int a, int b)
// {
//     if(a<=b) return $"{a} " + NumbersRec(a+1, b);
//     else return String.Empty;
// }

// Console.WriteLine(NumbersFor(1, 10)); 
// Console.WriteLine(NumbersRec(1, 10)); 

string NumbersRec(int a, int b)
{
    if (a > b) return $"{b} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));