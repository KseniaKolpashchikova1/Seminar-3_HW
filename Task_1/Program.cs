/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

using System;
using static System.Console;

Clear();


Write("Введите число = ");
int N = Convert.ToInt32(Console.ReadLine());
int rem, dig = 0, temp;
temp = N;
        while (N > 0)
        {
            rem = N % 10;  //for getting remainder by dividing with 10
            N = N / 10; //for getting quotient by dividing with 10
            dig = dig * 10 + rem; /*multiplying the sum with 10 and adding remainder*/
        }

        if (temp == dig) //checking whether the reversed number is equal to entered number
        {
            Console.WriteLine("Введенное число является палиндромом");
        }
        else
        {
            Console.WriteLine("Введенное число не является палиндромом");
        }
        Console.ReadLine();