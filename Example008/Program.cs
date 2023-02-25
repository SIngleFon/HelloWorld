int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 3;
int a2 = 25;
int a3 = 4;
int b1 = 4;
int b2 = 26;
int b3= 47;
int c1 = 1;
int c2 = 1;
int c3 = 100;

int max = Max(Max(a1,a2,a3), Max(b1,b2,b3), Max(c1,c2,c3));

Console.WriteLine(max);