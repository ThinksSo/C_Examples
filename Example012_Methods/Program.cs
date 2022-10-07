// METHODS - МЕТОДЫ
// Type 1 - ничего не принимают и не возвращают
void Method1()
{
    Console.WriteLine("Aythor ThinkSo");
}
Method1();


// Type 2 - не возвращают, принимают на входе аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Any text"); 
// именованные аргументы - указываем какое значение агрумента

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
   
}
Method2_1(msg: "Another text", count: 2); 
Method2_1(count: 2, msg: "New text"); 


// Type 3 - возвращают, но не принимают 
int Method3()
{
    return DateTime.Now.Year;
}
    
int year = Method3();
Console.WriteLine(year);

// Type 4 - принимают на входе аргументы, возвращают
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(5, "bla...");
Console.WriteLine(res);
