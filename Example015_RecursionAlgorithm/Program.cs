//РЕКУРСИИ

// Собрать строку с числами от а до b, a<=b, вариант - цикл
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

// Собрать строку с числами от а до b, a<=b, вариант - рекурсия
string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

// вывод строки в обратной последовательности, рекурсия
string CountdownRec(int a, int b)
{
    if (a <= b) return CountdownRec(a + 1, b) + $"{a} ";
    else return String.Empty;
}

// Сумма чисел от 1 до n, вариант - цикл
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

// Сумма чисел от 1 до n, вариант - рекурсия
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

// Факториал, вариант - цикл
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

// Факториал, вариант - рекурсия
int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

// Возведение a в степень n, вариант - цикл
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

// Возведение a в степень n, вариант - рекурсия
int PowerRec(int a, int n)
{
    // if (n == 0) return 1;
    // else return PowerRec(a, n - 1) * a;
    return n == 0 ? 1 : PowerRec(a, n - 1) * a;
}

// Возведение a в степень n, вариант - рекурсия и матем. формула
int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n /2);
    else return PowerRecMath(a, n - 1) * a;
}

// Перебор слов из заданных букв - рекурсия
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{new String(word) }"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}


Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 20));
Console.WriteLine(CountdownRec(1, 20));
Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));
Console.WriteLine(FactorialFor(10));
Console.WriteLine(FactorialRec(10));
Console.WriteLine(PowerFor(2, 10));
Console.WriteLine(PowerRec(2, 10));
Console.WriteLine(PowerRecMath(2, 10));
FindWords("coka", new char[3]);
