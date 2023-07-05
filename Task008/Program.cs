﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
n = Math.Abs(n);

Console.WriteLine("Четные числа от 1 до " + n + ":");

for (int i = 2; i <= n; i += 2)
{
    Console.Write(i+", ");
}
Console.Write(n);
