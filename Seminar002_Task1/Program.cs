//ПTask: роверка числа на результат возведения в квадрат

Console.Write("Input number 1 (square) ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2 ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2 * number2)
{
    Console.WriteLine($"Yea, {number1} is square of {number2}");
}
else
{
    Console.WriteLine("No");
}
Console.WriteLine();
