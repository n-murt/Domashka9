// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;
class Program
{

    static void Main(string[] args)
    {
        Console.Write("Задайте значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Все натуральные числа в промежутке от N до 1: ");
        NatNumbers(n);

    }

    static int NatNumbers(int n)
    {
        if (n == 1)
        {
            Console.Write("1");
            return 1;
        }

        Console.Write($"{n}, ");
        return NatNumbers(n - 1);
    }

}
