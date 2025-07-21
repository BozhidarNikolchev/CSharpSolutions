using System;

string password = Console.ReadLine();

bool isInRange = CheckNumberOfCharacters(password);
bool lettersAndDigitsOnly = CheckOnlyLettersAndDigits(password);
bool containsTwoDigits = ContainsTwoDigitsCheck(password);

if (!isInRange)
{
    Console.WriteLine("Password must be between 6 and 10 characters");
}

if (!lettersAndDigitsOnly)
{
    Console.WriteLine("Password must consist only of letters and digits");
}

if (!containsTwoDigits)
{
    Console.WriteLine("Password must have at least 2 digits");
}

if (isInRange && lettersAndDigitsOnly && containsTwoDigits)
{
    Console.WriteLine("Password is valid");
}

bool ContainsTwoDigitsCheck(string password)
{
    short counter = 0;

    for (int i = 0; i < password.Length; i++)
    {
        char currentChar = password[i];

        if (Char.IsDigit(currentChar))
        {
            counter++;
        }
    }

    return counter >= 2;
}

static bool CheckOnlyLettersAndDigits(string password)
{
    for (int i = 0; i < password.Length; i++)
    {
        char currentChar = password[i];

        if (!Char.IsLetter(currentChar) && !Char.IsDigit(currentChar))
        {
            return false;
        }
    }

    return true;
}

static bool CheckNumberOfCharacters(string password)
{
    return password.Length >= 6 && password.Length <= 10;
}