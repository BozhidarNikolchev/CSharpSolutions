char firstSymbol = char.Parse(Console.ReadLine());
char secondSymbol = char.Parse(Console.ReadLine());

PrintCharacterInRange(firstSymbol, secondSymbol);

void PrintCharacterInRange(char firstSymbol, char secondSymbol)
{
    int firstValue = (int)firstSymbol;
    int secondValue = (int)secondSymbol;

    if (firstValue > secondValue)
    {
        for (int i = secondValue + 1; i <= firstValue - 1; i++)
        {
            Console.Write((char)i + " ");
        }
    }
    else
    {
        for (int i = firstValue + 1; i <= secondValue - 1; i++)
        {
            Console.Write((char)i + " ");
        }
    }
}

//char a =  'a';
//int value = (int)a;
//Console.WriteLine(value);