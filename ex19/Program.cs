Console.Clear();
Console.Write("Введите число: ");
string number = Console.ReadLine()!;
int len=number.Length;
if (len==5)
{
    if( number[0]==number[4]&& number[1]==number[3])
    {
    Console.WriteLine("да");
    }
    else     
    {
    Console.WriteLine("нет");
    }
}
else
    {
    Console.WriteLine("число не 5-тизначное");
    }