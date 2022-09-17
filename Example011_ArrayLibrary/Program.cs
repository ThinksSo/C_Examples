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

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.Write("Enter number: ");
int x = Convert.ToInt32(Console.ReadLine());
int pos = IndexOf(array, x);

if (pos == -1) 
{
    Console.WriteLine("No such element");
}
else Console.WriteLine(pos);

Console.WriteLine();
