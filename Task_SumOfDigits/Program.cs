// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

try
{
    Console.WriteLine("Input the integer number, please");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"The sum of digits number {a}  is {GetSumGigit(a)}");
}
catch
{
    System.Console.WriteLine("You should enter integer number only!!!");
}

int GetSumGigit(int a)
{
    int numberGigit = (int)getNumberDigits(a);
    if (numberGigit == 1) return a;
    int result = 0;
    for (int i = 1; i <= numberGigit; i++)
    {
        result += a % 10;
        a /= 10;
    }
    return result;
}

double getNumberDigits(int n)
{
    int nAbs = Math.Abs(n);
    double result = Math.Log10(nAbs);
    return (int)result + 1;
}
