using System.Collections;

int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

int max = int.MinValue;
List<int> topIntegers = new List<int>();

for (int i = inputArray.Length - 1; i >= 0; i--)
{
    if (inputArray[i] > max)
    {
        topIntegers.Add(inputArray[i]);
        max = inputArray[i];
    }
    else
    {
        continue;
    }
}

topIntegers.Reverse();

foreach (int number in topIntegers)
{
    Console.Write(number + " ");
}
