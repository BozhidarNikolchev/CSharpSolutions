char[] chars = new char[3];

for (int i = 0; i < 3; i++)
{
    char inputChar = char.Parse(Console.ReadLine());
    chars[i] = inputChar;
}

Array.Reverse(chars);

foreach (char symbol in chars)
{
    Console.Write(symbol + " ");
}
