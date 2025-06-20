int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

while (inputArray.Length > 1)
{
    int[] condensed = new int[inputArray.Length - 1];

    for (int i = 0; i < condensed.Length; i++)
    {
        condensed[i] = inputArray[i] + inputArray[i + 1];
    }

    inputArray = condensed;
}

Console.WriteLine(inputArray[0]);