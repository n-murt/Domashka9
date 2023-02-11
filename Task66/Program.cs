// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке 
// от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
class Program
{

    static void Main(string[] args)
    {
        Console.Write("Задайте значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Задайте значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Сумма натуральных элементов в промежутке от M до N: {GapSum(m, n)}");

    }

    static int GapSum(int m, int n)
    {
        if (n < m)
        {
            Console.Write("Ошибка");
            return 0;
        }
        return n + GapSum(m, n - 1);
    }

}