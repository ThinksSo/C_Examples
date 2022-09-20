void Task9()
{
    // Вывести случайное число из отрезка [10, 99]
    // и показать наибольшую цифру из числа

    Random random = new Random(); 
    // создание объекта Random типа random
    int num = random.Next(10,100);
    Console.WriteLine(num);

    int tens = num / 10;
    int ones = num % 10;

    Console.WriteLine(tens);
    Console.WriteLine(ones);

    if (tens == ones) 
    {Console.WriteLine($"a = b = {tens} \n");}
    else if (tens > ones) 
    {Console.WriteLine($"max = {tens} \n");}
    else 
    {Console.WriteLine($"max = {ones} \n");}
}

// Task9();


void Task11()
{
    // В11. Напишите программу, которая выводит случайное трёхзначное число 
    // и удаляет вторую цифру этого числа.

    Random random = new Random(); 
  
    int num = random.Next(100,1000);
    Console.WriteLine(num);

    int thousands = num /100;
    int tens = num / 10;
    int ones = num % 10;

    Console.WriteLine(thousands * 10 + ones);
   
}

// Task11();


void Task12()
{
    // 12. Напишите программу, которая будет принимать на вход два числа 
    // и выводить, является ли второе число кратным первому. 
    // Если число 2 не кратно числу 1, то программа выводит остаток от деления.

    Console.WriteLine();
    Console.Write("Enter number 'a': ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number 'b': ");
    int b = Convert.ToInt32(Console.ReadLine());

    int dev = b % a;

    if (dev == 0)
    {
        Console.WriteLine($"{b} multiple {a}");
    }
    else
    {
        Console.WriteLine(dev);
    }
}

// Task12();

void Task14()
{
    // 114. Напишите программу, которая принимает на вход число 
    // и проверяет, кратно ли оно одновременно 7 и 23.

    Console.WriteLine();
    Console.Write("Enter number1: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    int dev = num1 % (7 * 23);

    if (dev == 0)
    {
        Console.WriteLine($"{num1} multiple 7 and 23");
    }
    else
    {
        Console.WriteLine("Not multiple");
    }
}

// Task14();


void Task16()
{
    // 16. Напишите программу, которая принимает на вход два числа 
    // и проверяет, является ли одно число квадратом другого.

    Console.WriteLine();
    Console.Write("Enter number 'a': ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number 'b': ");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a == b * b || b == a * a)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}

Task16();





