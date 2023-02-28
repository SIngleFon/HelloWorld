Console.Clear();
Console.WriteLine("Введите число от 1 до 10: ");
int a = int.Parse(Console.ReadLine() ?? "");

int b = new Random().Next(1, 11);
int i = 1;
int tr = 3;
while (i < tr)
{
    if (a == b)
    {
        Console.WriteLine("Ура-ура, вы угадали!");
        Console.WriteLine($"Вы угадали число c {i} попытки");
        break;
    }
    else if (i == tr)
    {
        Console.WriteLine("Вы исчерпали свои попытки");
    }
    else
    {
        Console.Write("Увы, не угадали, попробуйте снова: ");
        a = int.Parse(Console.ReadLine() ?? "");
        i++;
        if (i == tr)
        {
            Console.WriteLine("Вы исчерпали свои попытки");
        }
    }
}