int elCount = int.Parse(Console.ReadLine());

HashSet<string> orderedElements = ReadInputElements(elCount);

Console.WriteLine(string.Join(" ", orderedElements.OrderBy(el => el)));


static HashSet<string> ReadInputElements(int elCount)
{
    var resultSet = new HashSet<string>();

    for (int i = 0; i < elCount; i++)
    {
        string[] currentEl = Console.ReadLine()
            .Split()
            .ToArray();

        for (int j = 0; j < currentEl.Length; j++)
        {
            resultSet.Add(currentEl[j]);
        }
    }

    return resultSet;
}