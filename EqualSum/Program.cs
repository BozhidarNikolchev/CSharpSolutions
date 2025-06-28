int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

if (inputNumbers.Length == 1 || inputNumbers.Length == 0)
{
    Console.WriteLine(0);
    return;
}

bool areEqual = false;

for (int i = 0; i < inputNumbers.Length; i++)
{
    int leftSum = 0;
    int rightSum = 0;

    for (int leftNum = 0; leftNum < i; leftNum++)
    {
        leftSum += inputNumbers[leftNum];
    }

    for (int rightNum = i + 1; rightNum < inputNumbers.Length; rightNum++)
    {
        rightSum += inputNumbers[rightNum];
    }

    if (leftSum == rightSum)
    {
        Console.WriteLine(i);
        areEqual = true;
        return;
    }
}

if (areEqual == false)
{
    Console.WriteLine("no");
}

