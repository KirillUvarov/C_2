// Сортировка чисел в массиве
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
   int count = array.Length; 

   for (int i = 0; i < count; i++)
   {
    Console.Write($"{array[i]} ");
   }
   Console.WriteLine();
}
void SelectionSortMinToMax(int[] array)
{
    for (int i = 0; i < array.Length-1 ; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void SelectionSortMaxToMin(int[] array)
{
    for (int z = 0; z < array.Length-1 ; z++)
    {
        int maxPosition = z;
        for (int x = z + 1; x < array.Length; x++)
        {
           if(array[x] > array[maxPosition]) maxPosition = x;
        } 
    
        int temporary = array[z];
        array[z] = array[maxPosition];
        array[maxPosition] = temporary;
    }
    
}

PrintArray(arr);
SelectionSortMinToMax(arr);
PrintArray(arr);
SelectionSortMaxToMin(arr);
PrintArray(arr);
