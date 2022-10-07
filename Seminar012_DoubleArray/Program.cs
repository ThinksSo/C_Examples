
// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
void Task46()
{
    Console.WriteLine("\n \t Task 46: 2x Array Random");
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);

    int[,] numbers = new int[rows, columns];
    Console.WriteLine($"Array size: {rows}, {columns}");

    FillArray(numbers);
    PrintArray(numbers);

    Console.WriteLine();
}

void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(-100, 100);
        }

    }
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


/* Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: A = i+j. 
Выведите полученный массив на экран. m = 3, n = 4. 
0 1 2 3
1 2 3 4
2 3 4 5
*/
void Task48()
{
    Console.WriteLine("\n \t Task 48: 2x Array i+j");
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);

    int[,] numbers = new int[rows, columns];
    Console.WriteLine($"{rows}, {columns}");

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = i + j;
        }

    }
    PrintArray(numbers);
    Console.WriteLine();
}


/* Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты. 
*/
void Task49()
{
    Console.WriteLine("\n \t Task 49: 2x Array Square elements");
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Array size: {rows}, {columns}");
    int sum = 0;

    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);

    for (int i = 0; i < rows; i+=2)
    {
        for (int j = 0; j < columns; j+=2)
        {
            {
                numbers[i, j] = numbers[i, j] * numbers[i, j];
            }
        }
    }
    PrintArray(numbers);
    Console.WriteLine();
}


/* Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив: 1 4 72
5 9 23
8 4 24
Сумма элементов главной диагонали: 1+9+2 = 12
*/
void Task51()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = rows;
    int sum = 0;
    Console.WriteLine($"Array size: {rows}, {columns}");

    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j)
            {
                sum = sum + numbers[i, j];
            }
        }
    }
    Console.WriteLine();
}


/*
Дан двумерный массив из двух строк и двадцати двух столбцов. В его первой строке записано количество мячей, забитых футбольной командой в той 
или иной игре, во второй — количество пропущенных мячей в этой же игре. 
а) Для  каждой  проведенной  игры  напечатать  словесный  результат:  "выигрыш", "ничья" или "проигрыш".

а) Для  каждой  проведенной  игры  напечатать  словесный  результат:  "выигрыш", "ничья" или "проигрыш". 
б) Определить количество выигрышей данной команды. 
в) Определить  количество  выигрышей  и  количество  проигрышей  данной команды. 
г) Определить количество выигрышей, количество ничьих и количество проигрышей данной команды. 
д) Определить,  в  скольких  играх  разность  забитых  и  пропущенных  мячей была большей или равной трем. 
е) Определить общее число очков, набранных командой (за выигрыш даются 3 очка, за ничью — 1, за проигрыш — 0).
*/
void TaskArayGame()
{
    Console.WriteLine("\n \t Task: 2xArray: Win - Lose");
    Random random = new Random();
    int rows = 2;
    int columns = 22;
    Console.WriteLine($"{rows}, {columns}");
    int[,] numbers = new int[rows, columns];

    FillArrayCustom(numbers, 0, 10);
    PrintArray(numbers);
    int win = 0, lose = 0, draw = 0;

    for (int i = 0; i < columns; i++)
    {
        if (numbers[0, i] > numbers[1, i])
        {
            win++;
            Console.WriteLine($"Win -  {numbers[0, i]} : {numbers[1, i]}");
        }
        if (numbers[0, i] < numbers[1, i])
        {
            lose++;
            Console.WriteLine($"Lose -  {numbers[0, i]} : {numbers[1, i]}");
        }
        if (numbers[0, i] == numbers[1, i])
        {
            lose++;
            Console.WriteLine($"Draw -  {numbers[0, i]} : {numbers[1, i]}");
        }
    }
    Console.WriteLine($"\n Win \t - {win}");
    Console.WriteLine($"Lose \t - {lose}");
    Console.WriteLine($"Draw \t - {draw}");

    int points = win * 3 + draw;
    System.Console.WriteLine($"Points:  {points}");
}

void FillArrayCustom(int[,] numbers, int goals = 0, int missed = 1)
{
    missed++;
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(goals, missed);
        }
    }
}



Task46();
Task48();
Task49();
Task51();
TaskArayGame();



