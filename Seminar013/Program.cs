// SEMINAR 8
/* Задача 53: Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/
void Task53()
{
    Console.WriteLine("\n \t Task 53: 2xArray: Change first - last");
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);

    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);

    int min_i = 0;
    int max_i = rows - 1;
    for (int j = 0; j < columns; j++)
    {
        (numbers[min_i, j], numbers[max_i, j]) =
                                (numbers[max_i, j], numbers[min_i, j]);

    }

    Console.WriteLine();
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
            numbers[i, j] = random.Next(0, 10);
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
            Console.Write($"{numbers[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


/* Задача 55: Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/
void Task55()
{
    Console.WriteLine("\n \t Task 55: 2xArray: Change columns/rows");
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = rows;

    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);

    if (rows == columns)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = i; j < columns; j++)
            {
                int temp = numbers[i, j];
                (numbers[i, j]) = (numbers[j, i]);
                (numbers[j, i]) = temp;
                // вариант кортеджем:
                // (numbers[i, j], numbers[j, i]) =  (numbers[j, i], numbers[i, j]);
            }
        }
    }

    Console.WriteLine();
    PrintArray(numbers);
    Console.WriteLine();
}


/* Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.
*/
void Task57()
{
    Console.WriteLine("\n \t Task 57: 2xArray: count number");
    
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    int[] array_sum = new int[10];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array_sum[numbers[i, j]]++;
        }
    }

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"{i} => {array_sum[i]}");
    }
    Console.WriteLine();
}


/* Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
Например, задан массив: 1472
5923    923
8424    424
5267    267
*/
void Task59()
{
    Console.WriteLine("\n \t Task 59: 2xArray: Delete columns/rows min number");
    var random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);

    int min = numbers[0, 0];
    int i_min = 0;
    int j_min = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = i; j < columns; j++)
        {
            if (numbers[i, j] < min)
            {
                min = numbers[i, j];
                i_min = i;
                j_min = j;
            }
            // Console.WriteLine($"N[{i_min + 1}, {j_min + 1}] = {min}");
        }
    }

    int rowsResult = rows - 1;
    int columnsResult = columns - 1;
    int[,] result = new int[rowsResult, columnsResult];
    int bias_i = 0;
    int bias_j = 0;
    for (int i = 0; i < rowsResult; i++)
    {
        if (i == i_min) bias_i++;
        bias_j = 0;

        for (int j = 0; j < columnsResult; j++)
        {
            if (j == j_min) bias_j++;
            result[i, j] = numbers[i + bias_i, j + bias_j];
        }
    }
    Console.WriteLine();
    PrintArray(result);
}



Task53();
Task55();
Task57();
Task59();
