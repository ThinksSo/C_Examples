// Task: 

Console.Clear();
//ВВОД И ВЫВОД
Console.WriteLine();
Console.WriteLine("ВВОД И ВЫВОД");

Console.Write("Input number ");
// тип_данных имя_переменной = значение_переменной
int a = Convert.ToInt32(Console.ReadLine());
int b = a * a;

Console.WriteLine($"{a} * {a} = {b}");
Console.WriteLine($"Square = {b}"); // Интерполяция
Console.WriteLine("Square = " + b);


//ВЕТВЛЕНИЕ
Console.WriteLine();
Console.WriteLine("ВЕТВЛЕНИЕ");
Console.WriteLine("Input 0 or 1");
int rain = Convert.ToInt32(Console.ReadLine()); //1 - no, 0 - yes
if (rain == 1)
{
    Console.WriteLine("Rain");
}
else
{
    Console.WriteLine("Clear day");
}

//ЦИКЛ
Console.WriteLine();
Console.WriteLine("ЦИКЛ");

int time = 11;
while(time < 22)
{
    time++;
    Console.WriteLine("You have time for rest " + time);
}
Console.Write("Time to sleep ");
Console.WriteLine(time);
Console.WriteLine();
