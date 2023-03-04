int[] array = { 512, 21, 153, 52, 1, 35, 1257}; 

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            {
                minPosition = j;
            }     
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void SelectionSort1(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int maxPos = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPos])
            {
                maxPos = j;
            }
        }
        int temp = array[i];
        array[i] = array[maxPos];
        array[maxPos] = temp;
    }
}
SelectionSort1(array);
PrintArray(array);
SelectionSort(array);
PrintArray(array);