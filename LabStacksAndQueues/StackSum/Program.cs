int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

var elements = new Stack<int>(numbers);

while (true)
{
    string[] commands = Console.ReadLine().ToLower().Split();

    if (commands.Contains("end"))
    {
        break;
    }

    if (commands.Contains("add"))
    {
        int firstNum = int.Parse(commands[1]);
        int secondNum = int.Parse(commands[2]);

        elements.Push(firstNum);
        elements.Push(secondNum);
    }
    else if (commands.Contains("remove"))
    {
        int removeNumbersCount = int.Parse(commands[1]);

        if (elements.Count >= removeNumbersCount)
        {
            for (int i = 0; i < removeNumbersCount; i++)
            {
                elements.Pop();
            }
        }
    }
}

Console.WriteLine($"Sum: {elements.Sum()}");