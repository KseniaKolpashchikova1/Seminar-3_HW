//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using System;
using static System.Console;

Write("Введите число N =");
int N = int.Parse(ReadLine());

int count = 1;
while (count<N)
{
    Write($"{Math.Pow (count,3)}, ");
    count++;
}
Write($"{Math.Pow (count,3)}");

