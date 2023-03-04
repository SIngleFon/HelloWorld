Console.Clear();

//1

void method()
{
    Console.WriteLine("Good");
}

method();

//2

void method2(string msg, int count)
{
    for(int i = 0; i < count; i++)
    {
    Console.WriteLine(msg);
    }
}
method2("hm", 1);

//3

int method3()
{
    return DateTime.Now.Year;
}
int year = method3();
Console.WriteLine(year);

//4

string method4(int count, string ahaa)
{
    string result = string.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + ahaa;
    }
    return result;
}
string res = method4(4, "Goog");
Console.WriteLine(res);