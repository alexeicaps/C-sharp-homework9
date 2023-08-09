// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Type numbers of N elements: ");
int N = int.Parse(Console.ReadLine()!);
PrintArray(N);


void PrintArray(int n)
{
    if (n == 1)
    {
        Console.Write($"{n}");
    }
    else if (n > 0)
    {
        Console.Write($"{n}, ");
        PrintArray(n - 1);
    }
    else if (n < 2)
    {
        Console.Write($"{n}, ");
        PrintArray(n + 1);
    }
}

