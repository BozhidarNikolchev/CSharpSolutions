Action<int[]> numsCount = (int[] array) => Console.WriteLine(array.Count());
Func<int[], int> numsSum = (array) => array.Sum();

var inputNums = Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
    .Select(int.Parse)
    .ToArray();

numsCount(inputNums);
Console.WriteLine(numsSum(inputNums));
