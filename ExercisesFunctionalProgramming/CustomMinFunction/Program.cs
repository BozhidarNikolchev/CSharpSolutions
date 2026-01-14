int[] inputNumbers = Console.ReadLine()!
    .Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
    .Select(int.Parse)
    .ToArray();

int minNumber = Aggregate(inputNumbers, int.MaxValue, (a, b) => Math.Min(a, b));
Console.WriteLine(minNumber);

static int Aggregate(int[] array, int initialValue, Func<int, int, int> func)
{
    int result = initialValue;
    foreach (int number in array)
    {
        result = func(result, number);
    }

    return result;
}