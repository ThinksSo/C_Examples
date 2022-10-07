
/*
Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
*/
void Task39()
{
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, -10, 10);
    ReversArray(numbers);
    PrintArray(numbers);

    // int maxIndex = size - 1;
    // for (int i = 0; i < size / 2; i++)
    {
        // int temp = numbers[i];
        // numbers[i] = numbers[maxIndex - i];
        // numbers[maxIndex - i] = temp;
        // (numbers[i], numbers[maxIndex - i]) = (numbers[maxIndex -i], numbers[i]);
        //кортедж
    }
    PrintArray(numbers);
}

void ReversArray(int[] numbers)
{
    int size = 10;
    int maxIndex = size - 1;
    for (int i = 0; i < size / 2; i++)
    {
        (numbers[i], numbers[maxIndex - i]) = (numbers[maxIndex - i], numbers[i]);
    }
}

void FillArray(int[] numbers,
                int minValue = 0,
                int maxValue = 9)
{
    int size = numbers.Length;
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        numbers[i] = random.Next(minValue, maxValue);
    }
}

void PrintArray(int[] numbers)
{
    int size = numbers.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}


/*
Задача 40: Напишите программу, которая принимает на вход три числа 
и проверяет, может ли существовать треугольник со сторонами такой длины.
*/
void Task40()
{
    Console.WriteLine("\n \t Task 40");

    Console.Write("Enter side a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter side b: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter side c: ");
    int c = Convert.ToInt32(Console.ReadLine());

    if (a + b > c && a + c > b && b + c > a) Console.WriteLine("triangle exists");
    else Console.WriteLine("triangle does'nt exist");
}


/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
*/
void Task42()
{
    Console.WriteLine("\n \t Task 42");
    Console.Write("Enter number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    string result = "";

    while (num > 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    Console.WriteLine(result);
    Console.WriteLine();
}

void Task42_2()
{
    Console.WriteLine("\n \t Task 42_2");
    Console.Write("Enter number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    string result = Convert.ToString(num, 2);
    Console.WriteLine(result);
    Console.WriteLine();
}

//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
void Task44()
{
    Console.WriteLine("\n \t Task 44");
    Console.Write("Enter number: ");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] numbersFib = new int[size];
    numbersFib[0] = 0;
    numbersFib[1] = 1;

    for (int i = 2; i < size; i++)
    {
        numbersFib[i] = numbersFib[i - 2] + numbersFib[i - 1];
    }
    PrintArray(numbersFib);
}


/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.
*/
void Task45()
{
    Console.WriteLine("\n \t Task 45");
    Console.Write("Enter number: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    int[] otherNum = new int[size];
    FillArray(numbers);
    PrintArray(numbers);

    for (int i = 0; i < size; i++)
    {
        otherNum[i] = numbers[i];
    }
    Console.WriteLine();
    PrintArray(otherNum);
}


void Recursion(int test = 0)
{
    if (test == 100) return;
    // test++;
    Console.WriteLine(test);
    Recursion(++test);
}



// Task39();
// Task40();
// Task42();
// Task42_2();
// Task45();
Recursion();




