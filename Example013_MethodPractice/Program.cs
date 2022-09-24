//Cycle "for" (цикл "for")
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(5, "bla...");
Console.WriteLine(res);


// Multiplication table (Таблица умножениея)
for (int i = 2; i < 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

// Replaces in text (Замены в тексте)


