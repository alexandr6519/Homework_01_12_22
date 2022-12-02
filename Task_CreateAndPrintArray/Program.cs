int[] numbers = ReadNumbersAndCreateArray(8);
if (numbers.Length > 0) PrintArray(numbers);

int[] ReadNumbersAndCreateArray(int n)
{
    try
    {
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Input {i + 1} number of array");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        return numbers;
    }
    catch
    {
        Console.WriteLine("You inputed incorrect number!!!");
        return new int[0];
    }
}
    void PrintArray(int[] array)
    {
        Console.Write("(");
        for (int i = 0; i < array.Length; i++)
        {
            if (i < array.Length - 1)
                Console.Write($" {array[i]},");
            else Console.Write($" {array[i]})");
        }
    }
