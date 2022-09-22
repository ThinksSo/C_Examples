void Task17()
{
    /* 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
    причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
    */

    Random random = new Random();
    int x = random.Next(-10, 11);
    int y = random.Next(-10, 11);
    Console.WriteLine($"A({x}, {y})");

    if (x > 0 && y > 0)
    {
        Console.WriteLine("Point in 1st quarter");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Point in 2nd quarter");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Point in 3 quarter");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Point in 4 quarter");
    }
}

void Task18()
{
    /* Задача 18: Напишите программу, которая по заданному номеру четверти, 
    показывает диапазон возможных координат точек в этой четверти (x и y).
    */

    Console.Write("Enter number from 1 to 4 : ");
    int quart = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Quarter - {quart}");

    if (quart == 1) Console.WriteLine("range - (x > 0, y > 0)");
    else if (quart == 2) Console.WriteLine("range - (x < 0, y > 0)");
    else if (quart == 3) Console.WriteLine("range - (x < 0, y < 0)");
    else if (quart == 3) Console.WriteLine("range - (x < 0, y < 0)");
    else Console.WriteLine("Invalid input");
}


//Task17();
Task18();