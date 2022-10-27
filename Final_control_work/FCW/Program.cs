// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых <=3 символа.



// string[] arr_1 = new string[4] {"hello", "2", "world", ":-)"};
string[] arr_1 = new string[4] {"1234", "1567", "-2", "computer science"};
// string[] arr_1 = new string[3] {"Russia", "Denmark", "Kazan"};
// string[] arr_1 = new string[5] { "123", "12345", "1", "1234", "12" };
string[] arr_2 = new string[arr_1.Length];

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void ArrayString(string[] arr_1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < arr_1.Length; i++)
    {
        
        if (arr_1[i].Length <= 3)
        {
            arr_2[count] = arr_1[i];
            count++;
        }
    }
}

ArrayString(arr_1, arr_2);
PrintArray(arr_1);
Console.WriteLine("==================");
PrintArray(arr_2);