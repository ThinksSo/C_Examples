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
        numbers[i] = random.Next(-10, 100);
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
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    ChangeValue(numbers);
    PrintArray(numbers);
    Console.WriteLine();
}

void ChangeValue(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] *= -1;
    }
}

//Задача 33: Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
void Task33()
{
    int size = 12;
    int[] numbers = new int[size]; 
    FillArray(numbers);
    PrintArray(numbers);
    CheckArray(numbers, check);
}

void CheckArray(int[] numbers, int check)
{
    
    bool flag = false;
    /*
    for (int i = 0; i < numbers.Length; i++)
    {
        if(check == numbers[i]) flag = true;
    }
    if (flag == true)
    */

/*
    int i = 0;
    while(!flag && i = numbers.Length)
    {
        if(check == numbers[i]) 
        {
            flag = true;
        }
        i++;
    }
    if (flag)
    Console.WriteLine($"{check} in array");
    else
    Console.WriteLine($"{check} not in array");
}
*/


/*
Задача 35: Задайте одномерный массив, состоящий из случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
void Task35()
{
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    FindArray(numbers);
}

void FindArray(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] >= 10 && numbers[i] < 99) count++;
    }
    Console.WriteLine(count);
    Console.WriteLine();
}


// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
void Task37()
{
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);

    int maxIndex = size - 1;
    for (int i = 0; i < size/2; i++)
    {
        Console.WriteLine($"{numbers[i]} x {numbers[maxIndex - i]} = {numbers[i] * numbers[maxIndex]}");
    }
    if (size % 2 == 1) Console.WriteLine(numbers[size/2]);

    Console.WriteLine();
}


//Task31();
// Task32();
// Task33();
Task35();
Task37();


/*
Задача 2. Напишите метод, который заполняет массив случайным количеством (от 1 до 100) нулей и единиц. 
Размер массива должен совпадать с квадратом количества единиц в нём.
*/
void Task1S4()
{
    Random random = new Random();
    int countOnes = random.Next(1, 11);
    Console.WriteLine("Q-ty elements " + countOnes);
    int size = countOnes * countOnes;
    int[] numbers = new int[size];
    int randomIndex = random.Next(0, size);

    for (int i = 0; i < countOnes; i++)
    {
        while(numbers[randomIndex] ==1)
        {
            Console.WriteLine($"Element {randomIndex + 1} = 1, search next");
            randomIndex = random.Next(0, size);
        }
        numbers[randomIndex] = 1;
        System.Console.WriteLine($"Element {randomIndex + 1} -> 1");
    }
    PrintArray(numbers);
}



Task1S4();


