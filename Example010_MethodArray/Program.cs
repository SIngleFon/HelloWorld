int[] array = {1, 2, 6, 4, 5, 6, 7, 8, 9};
int n = array.Length;
int find = 6;
int index = 0;
while(index < n)
{
    if(array[index]==find) 
    {
        Console.WriteLine(index);
        break; //Прервать операцию после нахождения первого индека find
    }
    index++;
}
