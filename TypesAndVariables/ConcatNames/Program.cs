string[] concatNames = new string[3];

for (int i = 0; i < 3; i++)
{
    string currentString = Console.ReadLine();

    concatNames[i] = currentString;
}

Console.WriteLine($"{concatNames[0]}{concatNames[2]}{concatNames[1]}");