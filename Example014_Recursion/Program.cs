//ДВУХМЕРНЫЕ МАССИВЫ

void Table1()
{
    string[,] table = new string[2, 5];
    //String.Empty
    // table [0,0]  table [0,1] table [0,2] table [0,4]
    // table[1,0]    table[1,1] table[1,2] table[1,4] 
    table[1, 2] = "text";

    for (int rws = 0; rws < 2; rws++)
    {
        for (int columns = 0; columns < 5; columns++)
        {
            Console.WriteLine($" - {table[rws, columns]} - ");
        }
    }
}

// Заполнение массива
void FillArray2X(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

// Печать массива
void PrintArray2X(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


// Table1();

int[,] matrix = new int[3, 4];
FillArray2X(matrix);
PrintArray2X(matrix);


// RECURSION - РЕКУРСИЯ


int[,] pic = new int[,]
{
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
    {0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0 },
    {0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 },
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
    {0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 },
    {0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0 },
    {0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};


// Print image - печать картинки
void PrintImag(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            // Console.Write($"{image[i, j]} ");
            if(image[i,j] == 0) Console.Write(" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Filling image - заполнение/закраска картинки
void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}

PrintImag(pic);
FillImage(5, 5);
PrintImag(pic);


// Factorial - Факториал
double Factorial(int n)
{
    // 1! = 1; 0! = 1;  3! = 1 * 2 * 3 = 6
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}

for (int i = 1; i < 5; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
Console.WriteLine();


// Fibonacci - Числа Фибоначчи
// 1123581321 -> f(1) = 1, f(2) = 1, f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}

