
string input = Console.ReadLine();

MiddleCharacterPrint(input);


static void MiddleCharacterPrint(string text)
{
    if (text.Length % 2 != 0)
    {
        int middleChar = text.Length / 2;
        char result = text[middleChar];

        Console.WriteLine(result);
    }
    else
    {
        int secondMiddleChar = text.Length / 2;
        int firstMiddleChar = secondMiddleChar - 1;

        char secondChar = text[secondMiddleChar];
        char firstChar = text[firstMiddleChar];

        Console.WriteLine($"{firstChar}{secondChar}");
    }
}