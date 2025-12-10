int[] inputNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int firstSetLength = inputNumbers[0];
int secondSetLength = inputNumbers[1];

var firstSet = ReadSet(firstSetLength);
var secondSet = ReadSet(secondSetLength);

var uniqueElements = FindUniqueElements(firstSet, secondSet);

Console.WriteLine(string.Join(" ", uniqueElements));


static List<int> FindUniqueElements(HashSet<int> firstSet, HashSet<int> secondSet)
{
    List<int> uniqueResult = new List<int>();

    foreach (int element in firstSet)
    {
        if (secondSet.Contains(element))
        {
            uniqueResult.Add(element);
        }
    }

    return uniqueResult;
}

static HashSet<int> ReadSet(int setLength)
{
    var resultSet = new HashSet<int>();

    for (int i = 0; i < setLength; i++)
    {
        int currentNumber = int.Parse(Console.ReadLine());
        resultSet.Add(currentNumber);
    }

    return resultSet;
}