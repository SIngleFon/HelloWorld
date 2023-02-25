void FillArray(int[] Collection)
{
    int Length = Collection.Length;
    int index = 0;
    while(index < Length)
    {
        Collection[index] = new Random().Next(1, 400);
        index++;
    }
}
void PrintArray(int[] Col)
{
    int count = Col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(Col[position]);
        position++;
    }
}

int IndexOf(int[] Collection, int find)
{
    int count = Collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if(Collection[index] == find)
        {
            position = index;
            break;
        }
    index++;
    }
    return position;
}
int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 48);
Console.WriteLine(pos);