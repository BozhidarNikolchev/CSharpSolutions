string inputText = Console.ReadLine();

Stack<char> chars = new Stack<char>();

for (int i = 0; i < inputText.Length; i++)
{
    chars.Push(inputText[i]);
}

Console.WriteLine(chars.ToArray());