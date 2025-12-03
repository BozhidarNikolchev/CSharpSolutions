int inputNumber = int.Parse(Console.ReadLine());

for (int i = 1; i <= inputNumber; i++)
{
    bool digitsDivisibleByEight = SumOfDigitsDivisibleByEight(i);
    bool hasOneOddDigit = CheckForAtLeastOneOddDigit(i);

    if (digitsDivisibleByEight && hasOneOddDigit)
    {
        Console.WriteLine(i);
    }
}

bool CheckForAtLeastOneOddDigit(int number)
{
    int[] arrayOfDigits = number.ToString().Select(d => int.Parse(d.ToString())).ToArray();

    for (int i = 0; i < arrayOfDigits.Length; i++)
    {
        int digit = arrayOfDigits[i];

        if (digit % 2 != 0)
        {
            return true;
        }
    }

    return false;
}

static bool SumOfDigitsDivisibleByEight(int number)
{
    int[] arrayOfDigits = number.ToString().Select(d => int.Parse(d.ToString())).ToArray();
    int sumOfDigits = 0;

    for (int i = 0; i < arrayOfDigits.Length; i++)
    {
        sumOfDigits += arrayOfDigits[i];
    }

    return sumOfDigits % 8 == 0;
}