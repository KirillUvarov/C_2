int[] arr = { 100, 22, 4, 55, 26, 7, 10, 9, 10, 11 };

static void Main(string[] args)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int min = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[min])
            {
                min = j;
            }
        }
        int help = arr[i];
        arr[i] = arr[min];
        arr[min] = help;
        Console.Write($"{arr[i]} ");
    }
}
