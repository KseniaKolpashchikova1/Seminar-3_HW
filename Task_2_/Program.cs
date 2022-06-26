/* Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
//√((x2-x1)^2)+(y2-y1)^2+(z2-z1)^2
using System;
using static System.Console;

Write("Введите координаты точки А (x) = ");
int x = int.Parse(ReadLine ());

Write("Введите координаты точки А (y) = ");
int y = int.Parse(ReadLine ());

Write("Введите координаты точки А (z) = ");
int z = int.Parse(ReadLine ());

Write("Введите координаты точки B (x1) = ");
int x1 = int.Parse(ReadLine ());

Write("Введите координаты точки B (y1) = ");
int y1 = int.Parse(ReadLine ());

Write("Введите координаты точки B (z1) = ");
int z1 = int.Parse(ReadLine ());
Double XYZ = Math.Sqrt (Math.Pow(x-x1,2)+Math.Pow(y-y1,2)+Math.Pow(z-z1,2));

Console.Write($"Расстояние между заданнами точками в 3D пространстве составляет = {XYZ:f2}");