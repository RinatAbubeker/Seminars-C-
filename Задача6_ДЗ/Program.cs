﻿Console.Clear();      // Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
{
Console.WriteLine("Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (c % 2 == 0) Console.WriteLine("Число четное");
else Console.WriteLine("Число нечетное");
}