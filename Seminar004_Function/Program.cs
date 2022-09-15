//ФУНКЦИИ
Console.Clear();
Console.WriteLine();
Console.WriteLine("ФУНКЦИИ");


//Функция возведения числа в квадрат
int Power(int x)
{
    return x * x;
}

Console.Write("Input number ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Power(number));
Console.WriteLine();

