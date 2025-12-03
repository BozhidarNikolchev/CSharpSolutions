int symbolToBeAdded = int.Parse(Console.ReadLine());
int counter = int.Parse(Console.ReadLine());

List<string> arrayOfSymbols = new List<string>();

for (int i = 0; i < counter; i++)
{
    string input = Console.ReadLine();
    if (string.IsNullOrEmpty(input) || input.Length != 1) continue;

    char currentChar = char.Parse(input);

    if (!char.IsLetter(currentChar)) continue;

    int charToNumber = (int)currentChar;
    char currentSymbolDecrypted = (char)((symbolToBeAdded + charToNumber) % 256);

    arrayOfSymbols.Add(currentSymbolDecrypted.ToString());
}

if (arrayOfSymbols.Count > 0)
{
    arrayOfSymbols[0] = arrayOfSymbols[0].ToUpper();
}

Console.WriteLine(string.Join("", arrayOfSymbols));
