int[] array = { 12, 23, 54, 2, 99, 75, 40, 34 };

int n = array.Length;
int find = 75;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;    // index = index +1;
}