// Задача 26. - HARD необязательная Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4
Console.WriteLine("Input any number, please");
double number = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"The count of digits of {number} is {GetNumberDigitsOfDouble(number)}");


int GetNumberDigitsOfDouble(double a)
{
    int result = (int)GetNumberDigitsIntNumber((int)(a));
    if (!HasFractionalPart(number)) return result;
    else
    {
        while (a % 10 != 0)
        {
            result++;
            a *= 10;
        }
        return result - 1;
    }
}

bool HasFractionalPart(double a)
{
    if (a == (int)a) return false;
    return true;
}

double GetNumberDigitsIntNumber(int n)
{
    if (n < 1) return 0;
    int nAbs = Math.Abs(n);
    double result = Math.Log10(nAbs);
    return (int)result + 1;
}