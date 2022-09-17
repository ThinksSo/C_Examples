int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 23;
int b1 = 145;
int c1 = 39;
int a2 = 16;
int b2 = 28;
int c2 = 98;
int a3 = 324;
int b3 = 78;
int c3 = 5;

// int max1 = Max(arg1, b1, c1);

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));


Console.WriteLine(max);
