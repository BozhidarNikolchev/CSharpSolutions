
string inputString = Console.ReadLine();

PrintNumberOfVowels(inputString);

static void PrintNumberOfVowels(string inputText)
{
    string text = inputText.ToLower();
    int numberOfVowels = 0;

    for (int i = 0; i < text.Length; i++)
    {
        if ((text[i].CompareTo('a') == 0) ||
            (text[i].CompareTo('o') == 0) ||
            (text[i].CompareTo('u') == 0) ||
            (text[i].CompareTo('e') == 0) ||
            (text[i].CompareTo('i') == 0))
        {
            numberOfVowels++;
        }
    }

    Console.WriteLine(numberOfVowels);
}