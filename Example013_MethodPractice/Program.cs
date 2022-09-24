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

string text = "Три вещи может сделать женщина для русского писателя. " 
            + "Она может кормить его. "
            + "Она может искренне поверить в его гениальность. "
            + "И наконец, женщина может оставить его в покое. "
            + "Кстати, третье не исключает второго и первого.";

string Replace(string text, char oldValue, char newValue)
{
    string result  = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
