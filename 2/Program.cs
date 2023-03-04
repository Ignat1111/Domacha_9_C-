// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите значение М ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N ");
int N = int.Parse(Console.ReadLine()!);
SumCommon(M,N);

void SumCommon(int M,int N)
{
   Console.Write(SumMN(M -1, N));
}

int SumMN(int M, int N)
{
   int summ = M;
   if (M == N)
   {
      return 0;
   }
   else
   {
      M++;
      summ =M +SumMN(M,N);
      return summ;
   }
}