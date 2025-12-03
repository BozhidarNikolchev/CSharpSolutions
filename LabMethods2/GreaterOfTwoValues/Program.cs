string type = Console.ReadLine();

if (type == "int")
{
    int firstNum = int.Parse(Console.ReadLine());
    int secondNum = int.Parse(Console.ReadLine());

    GetMaxInt(firstNum, secondNum);
}
else if (type == "char")
{
    char firstChar = char.Parse(Console.ReadLine());
    char secondChar = char.Parse(Console.ReadLine());

    GetMaxChar(firstChar, secondChar);
}
else if (type == "string")
{
    string firstString = Console.ReadLine();
    string secondString = Console.ReadLine();

    GetMaxString(firstString, secondString);
}

static void GetMaxInt(int firstNum, int secondNum)
{
    if (firstNum > secondNum)
    {
        Console.WriteLine(firstNum);
    }
    else
    {
        Console.WriteLine(secondNum);
    }
}
static void GetMaxChar(char firstChar, char secondChar)
{
    if (firstChar > secondChar)
    {
        Console.WriteLine(firstChar);
    }
    else
    {
        Console.WriteLine(secondChar);
    }
}
static void GetMaxString(string firstString, string secondString)
{
    if (firstString.CompareTo(secondString) == 1)
    {
        Console.WriteLine(firstString);
    }
    else
    {
        Console.WriteLine(secondString);
    }
}