﻿// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());;

int result = 1;
int count = 1;

while (count <= N)
{
    result = result * count;
    count++;
}
Console.WriteLine(result);