// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16﻿
try
{
    Console.WriteLine("Please, input the integer number as base for exponentiation.");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please, input the integer positive number as degree of exponentiation.");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n < 1) Console.WriteLine("You inputed NOT positive number!");
    else
    {
        Console.WriteLine($"The result of raising number {a} to the power of {n} is {GetExponentiation(a, n)}");
    }
}
catch
{
    System.Console.WriteLine("You should enter integer number only!!!");
}

int GetExponentiation(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++) result *= a;
    return result;
}
