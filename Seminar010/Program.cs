/*
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
 Найдите сумму отрицательных и положительных элементов массива.
 */
/*
void Task31()
{
   int size = 12;
   int[] numbers = new int[size];
   FillArray(numbers, -9, 9);
   PrintArray(numbers);
   Console.WriteLine(GetSummPositive(numbers));
   Console.WriteLine(GetSummNegative(numbers));
}

void GetSummPositive(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
            sum += numbers[i];
    }
    return sum;
}

void GetSummNegative(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0)
            sum += numbers[i];
    }
    return sum;
}
*/

void FillArray(int[] numbers,
                int minValue = 0,
                int maxValue = 100)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(-9, 10);
    }
}


void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}


// Задача 32: Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

void Task32()
{
    int size = 12;
    int[] numbers = new int [size];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();
}


//Task31();
Task32();
