// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Задайте значения M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Задайте значения N: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write($"M = {M}; N = {N} -> {GetSumNumbers(M, N)}");


int GetSumNumbers(int m, int n)
{
    if (m < n)
    {
        return m + GetSumNumbers(m + 1, n);
    }
    else if (m > n) 
    {
        return n + GetSumNumbers(m, n + 1);
    }
    else
    {
        return n;
    }
}