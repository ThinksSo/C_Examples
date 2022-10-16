// SEMINAR 9
/* Задача 63: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/
void Task63()
{
    Console.WriteLine("\n \t Task 63: Number range");
    Console.Write("Enter number ");
    int number = Convert.ToInt32(Console.ReadLine());
    Range(number);
    Console.WriteLine();
}

void Range(int number, int counter = 0)
{
    counter++;
    Console.Write($"{counter} ");
    if (counter >= number)
        return;
    Range(number, counter);
}


/* Задача 65: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
 M = 1; N = 5 -> "1, 2, 3, 4, 5" M = 4; N = 8 -> "4, 6, 7, 8"
*/
void Task65()
{
    Console.WriteLine("\n \t Task 65: Number range n - m");
    Console.Write("Enter first number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter last number: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Range(m, n);
    Console.WriteLine();
}


/* Задача 67: Напишите программу, 
которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12 45 -> 9
*/
void Task67()
{
    Console.WriteLine("\n \t Task 67: Numbers sum");
    Console.Write("Enter number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(SumNumbers(num));
}


int SumNumbers(int number, int sumNum = 0)
{
    if (number == 0)
    {
        return sumNum;
    }
    sumNum = sumNum + number % 10;
    number = number / 10;
    return SumNumbers(number, sumNum);
}


/* Задача 69: Напишите программу, 
которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
 A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8
*/
// возведение в степень  - цикл и рекурсию
void Task69()
{
    Console.WriteLine("\n \t Task 69: Exponentiation");
    Console.Write("Enter number ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter degree: ");
    int b = Convert.ToInt32(Console.ReadLine());

    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
    Console.WriteLine($"{a} ^ {b} = {result}");
    
    // рекурсия
    Pow(a, b);
}


void Pow(int a, int b, int i = 0, int result = 1)
{
    if (i >= b)
    {
        Console.WriteLine($"{a} ^ {b} = {result}");
        return;
    }
    result *= a;
    i++;
    Pow(a, b, i, result);
}



Task63();
Task65();
Task67();
Task69();








