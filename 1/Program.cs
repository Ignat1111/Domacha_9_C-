﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

int count = 1;
Recursiv(N, count);

void Recursiv(int n, int count)
{
   if (count > n)
   {
      return;
   }
   else
   {
      Recursiv(n, count + 1);
      Console.Write(count + " ");
   }
}
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);


