void Task2()
{
    /* Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
    5 -> 2, 4
    8 -> 2, 4, 6, 8
    */

    Console.WriteLine();
    Console.Write("Enter number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int div = num % 2;
    int count = 2;

    Console.Write($"{num} -> ");
    if (num < 2) Console.Write("value less than 2");
    if (div != 0) num = num - 1;
    if (num >= 2) Console.Write(count);

    while (num > count)
    {
        count += 2;
        Console.Write($", {count}");
    }
    Console.WriteLine("\n");
}

void Task4()
{
    /* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    2, 3, 7 -> 7
    44 5 78 -> 78
    22 3 9 -> 22
    */

    Console.WriteLine();
    Console.Write("Enter number 1: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number 2: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number 3: ");
    int num3 = Convert.ToInt32(Console.ReadLine());
    int max = num1;

    if (num2 > max) max = num2;
    if (num3 > max) max = num3;

    Console.WriteLine($"\n{num1}, {num2}, {num3}  ->  max = {max} \n");
}

void Task6()
{
    /* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
    4 -> да
    -3 -> нет
    7 -> нет
    */

    Console.WriteLine();
    Console.Write("Enter number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int div = num % 2;
    //Console.WriteLine(div);

    if (div == 0) 
    {Console.WriteLine($"Number {num} -> yes (even) \n");}
    else
    Console.WriteLine($"Number {num} -> no (odd) \n");
}

void Task8()
{
    /* Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
    5 -> 2, 4
    8 -> 2, 4, 6, 8
    */

    Console.WriteLine();
    Console.Write("Enter number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int div = num % 2;
    int count = 2;

    Console.Write($"{num} -> ");
    if (num < 2) Console.Write("value less than 2");
    if (div != 0) num = num - 1;
    if (num >= 2) Console.Write(count);

    while (num > count)
    {
        count += 2;
        Console.Write($", {count}");
    }
    Console.WriteLine("\n");
}

Task2();
