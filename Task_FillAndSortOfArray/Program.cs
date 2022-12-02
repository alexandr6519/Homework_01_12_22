// Задача 30: HARD необязательная Напишите программу, которая на вход получает
// размерность массива. Далее заполняет его случайными уникальными числами и 
// выводит на экран. Далее производим сортировку массива от большего к меньшему 
//и выводим на экран. Далее придумываем алгоритм перемешивания списка на 
// основе случайности , применяем этот алгоритм и выводим 
// на экран результат.
Console.WriteLine("Input the integer positive number, please");
try
{
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 1) Console.WriteLine("You should enter POSITIVE number only!");
    else
    {
        int[] array = CreateRandomArray(number);
        Console.WriteLine("This is our array of randoming elements: ");
        PrintArray(array);
        SortArrayFromMaxToMin(array);
        Console.WriteLine("This is our sorting array from max to min: ");
        PrintArray(array);
        SortRandomArray(array);
        Console.WriteLine("This is our array in randoming order: ");
        PrintArray(array);
    }
}
catch
{
    Console.WriteLine("You should enter integer number only!!!");
}

int[] CreateRandomArray(int n)
{
    int[] numbers = new int[n];
    for (int i = 0; i < n; i++)
        numbers[i] = GetUniqueElement(numbers);
    return numbers;
}

bool IsUniqueElement(int element, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == element) return false;
    }
    return true;
}

int GetUniqueElement(int[] array)
{
    int temp = new Random().Next(1, 100);
    while (!IsUniqueElement(temp, array))
        temp = new Random().Next(1, 100);
    return temp;
}

void PrintArray(int[] array)
{
    if (array.Length > 0) Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($" {array[i]},");
        else Console.Write($" {array[i]})");
    }
    Console.WriteLine();
}

void SortArrayFromMaxToMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int indexMaxElement = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[indexMaxElement]) 
            indexMaxElement = j;
        }
        int temp = array[i];
        array[i] = array[indexMaxElement];
        array[indexMaxElement] = temp;
    }
}

void SortRandomArray(int[] array)
{
    int length = array.Length;
    int indexForChange = 0;
    for (int i = 0; i < length - 1; i++)
    {
        indexForChange = new Random().Next(i + 1, length);

        int temp = array[i];
        array[i] = array[indexForChange];
        array[indexForChange] = temp;
    }
}
