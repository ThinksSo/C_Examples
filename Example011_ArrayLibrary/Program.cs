void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1,100);
        index++;
    }
}

void PrintArray(int[] lib)
{
    int count = lib.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{lib[position]} ");
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

