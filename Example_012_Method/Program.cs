string text = "Каждому человеку нужно какое-нибудь хобби"
            + " — якобы с целью «выйти из стресса», — но ты-то прекрасно понимаешь,"
            + " что на самом деле люди попросту пытаются выжить и не сойти с ума.";

string text1 = "В идеальных отношениях чистая любовь и грязный секс дополняют, а не исключают друг друга.";


string method1(string name, char OldValue, char newValue)
{
    string edit = string.Empty;
    int Lenght = name.Length;
    for(int i = 0; i < Lenght; i++)
        {
            if(name[i] == OldValue) edit = edit + $"{newValue}";
            else edit = edit + $"{name[i]}";
        }
    return edit;
}
string newText = method1(text1, ' ', '_');
Console.WriteLine(newText);
Console.WriteLine();
string nove = method1(newText, 'а', 'A');
Console.WriteLine(nove);