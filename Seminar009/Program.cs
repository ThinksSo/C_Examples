/* Задача 24: Напишите программу, которая принимает на вход число (А) 
и выдаёт сумму чисел от 1 до А.
*/

void Task24()
{
    Console.WriteLine("\n \t Task 24");
    Console.Write("Enter number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int sum =0;
    
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"{i} + ");
        sum += i;
    }
    Console.WriteLine($"= {sum}");
}



/*
Задача 26: Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе.
*/
void Task26()
{
    Console.WriteLine("\n \t Task 26");
    Console.Write("Enter number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int count = 1;

    while (count < num)
    {
        num = num/10;
        count++;
    }
    Console.WriteLine($"{num} -> {count}"); 
}


void Task262()
{
    Console.WriteLine("\n \t Task 24");
    Console.Write("Enter number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{num} -> {Math.Ceiling(Math.Log10(num))}");
}


/*
Задача 28: Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.
*/
void Task28()
{
    Console.WriteLine("\n \t Task 28");
    Console.Write("Enter number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int factorial = 1;
    
    for (int i = 1; i <= num; i++)
    {
        factorial = factorial * i;
    }
    Console.WriteLine($"{num} -> {factorial}");   
}


/* Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
void Task30()
{
    Console.WriteLine("\n \t Task 30");
    Random random = new Random();
    int size = random.Next(4, 10);    
    int[] numbers = new int[size];
    Console.WriteLine(size);
    
    // FillArray(numbers);
    
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine($"Input {i+1} array element");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    PrintArray(numbers);
}


void FillArray(int[] num)
{
    Random random = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = random.Next(0,2);
    } 
}


void PrintArray(int[] num)
{
    Random random = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    } 
    Console.WriteLine();
}


// Task24();
// Task26();
// Task262();
// Task28();
Task30();




