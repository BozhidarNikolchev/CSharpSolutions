namespace CountSameValuesInArray;

class Program
{
    static void Main(string[] args)
    {
        var inputValues = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

        var valuesCounts = new Dictionary<double, int>();

        foreach (var currentNumber in inputValues)
        {
            if (!valuesCounts.ContainsKey(currentNumber))
            {
                valuesCounts[currentNumber] = 0;
            }

            valuesCounts[currentNumber]++;
        }

        foreach (var entry in valuesCounts)
        {
            var key = entry.Key;
            var value = entry.Value;

            Console.WriteLine($"{key} - {value} times");
        }
    }
}