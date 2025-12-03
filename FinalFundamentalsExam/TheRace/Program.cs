while (true)
{
    string input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
        break;

    int eqIndex = input.IndexOf('=');
    int exclIndex = input.IndexOf("!!");

    if (eqIndex == -1 || exclIndex == -1 || eqIndex > exclIndex)
    {
        Console.WriteLine("Nothing found!");
        continue;
    }

    string allowed = "#$%*&";
    char firstSymbol = input[0];
    if (eqIndex < 2 || !allowed.Contains(firstSymbol.ToString()))
    {
        Console.WriteLine("Nothing found!");
        continue;
    }
    int nameEnd = eqIndex - 1;
    char lastSymbol = input[nameEnd];
    if (lastSymbol != firstSymbol)
    {
        Console.WriteLine("Nothing found!");
        continue;
    }

    string name = input.Substring(1, nameEnd - 1);
    bool lettersOnly = true;
    for (int i = 0; i < name.Length; i++)
    {
        if (!char.IsLetter(name[i]))
        {
            lettersOnly = false;
            break;
        }
    }
    if (!lettersOnly)
    {
        Console.WriteLine("Nothing found!");
        continue;
    }

    string lenString = "";
    for (int i = eqIndex + 1; i < exclIndex; i++)
    {
        if (char.IsDigit(input[i]))
            lenString += input[i];
        else
            break;
    }
    int length = 0;
    if (!int.TryParse(lenString, out length) || length == 0)
    {
        Console.WriteLine("Nothing found!");
        continue;
    }

    int afterNum = eqIndex + 1 + lenString.Length;
    if (afterNum != exclIndex)
    {
        Console.WriteLine("Nothing found!");
        continue;
    }

    string code = input.Substring(exclIndex + 2);
    if (code.Length != length)
    {
        Console.WriteLine("Nothing found!");
        continue;
    }

    string decrypted = "";
    for (int i = 0; i < code.Length; i++)
    {
        decrypted += (char)(code[i] + length);
    }

    Console.WriteLine("Coordinates found! {0} -> {1}", name, decrypted);
    return;
}
    
