int inputNum = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int[] digits = inputNum.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();

int evenDigits = GetSumOfEvenDigits(digits);
int oddDigits = GetSumOfOddDigits(digits);

Console.WriteLine(GetMultipleOfEvenAndOdds(evenDigits, oddDigits));
static int GetMultipleOfEvenAndOdds(int evenDigits, int oddDigits)
{
    return evenDigits * oddDigits;
}

static int GetSumOfEvenDigits(int[] digits)
{
    int evenDigits = 0;

    for (int i = 0; i < digits.Length; i++)
    {
        if (digits[i] % 2 == 0)
        {
            evenDigits += digits[i];
        }
    }

    return evenDigits;
}

static int GetSumOfOddDigits(int[] digits)
{
    int oddDigits = 0;

    for (int i = 0; i < digits.Length; i++)
    {
        if (digits[i] % 2 != 0)
        {
            oddDigits += digits[i];
        }
    }

    return oddDigits;
}
