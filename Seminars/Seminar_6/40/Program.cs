// 3 -> 11

// 2 -> 10
Console.Write("Введите число для перевода в двоичную систему - ");
int a = Convert.ToInt32(Console.ReadLine());
int count=0;
int z=a;
int b = 0;
while (a>0)
{
    b=a%2;
    a=a/2;
    // Console.Write($"{b} ");
    count++;
}
int [] arr= new int[count];
int j=1;
while (z>0)
{
    arr[count-j]=z%2;
    z=z/2;
    j++;
}
 Console.WriteLine(" ");
Print(arr);
