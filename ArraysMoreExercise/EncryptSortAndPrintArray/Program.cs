int numberOfStrings = Convert.ToInt32(Console.ReadLine());

int[] proccessedArray = new int[numberOfStrings];

for (int i = 0; i < numberOfStrings; i++)
{
    string currentString = Console.ReadLine();

    int vowelMultiplication = EachVowelMultipliedByStringLength(currentString);
    int consonantDivision = EachConsonantDividedByStringLength(currentString);

    int sum = vowelMultiplication + consonantDivision;
    proccessedArray[i] = sum;

}

Array.Sort(proccessedArray);
foreach (int number in proccessedArray)
{
    Console.WriteLine(number);
}

static int EachConsonantDividedByStringLength(string text)
{
    int textLength = text.Length;
    int divisionResult = 0;

    foreach (char currentChar in text)
    {
        if (isConsonant(currentChar))
        {
            int charNumericValue = (int)currentChar;
            divisionResult += charNumericValue / textLength;
        }
    }

    return divisionResult;
}

static bool isConsonant(char letter)
{
    char symbol = char.ToLower(letter);
    return !isVowel(symbol);
}

static int EachVowelMultipliedByStringLength(string text)
{
    int textLength = text.Length;
    int multiplicationResult = 0;

    foreach (char currentChar in text)
    {
        if (isVowel(currentChar))
        {
            int charNumericValue = (int)currentChar;
            multiplicationResult += charNumericValue * textLength;
        }
    }

    return multiplicationResult;
}

static bool isVowel(char letter)
{
    char symbol = char.ToLower(letter);

    if (symbol == 'a' || symbol == 'o' ||
        symbol == 'u' || symbol == 'e' ||
        symbol == 'i')
    {
        return true;
    }

    return false;
}