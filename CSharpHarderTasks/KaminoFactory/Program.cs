class Program
{
    static void Main()
    {
        int sequenceLength = int.Parse(Console.ReadLine());

        int[] bestArray = new int[sequenceLength];
        int bestLength = 0;
        int bestStartIndex = int.MaxValue;
        int bestSum = 0;
        int bestSampleIndex = 0;
        int sampleIndex = 0;

        string input;
        while ((input = Console.ReadLine()) != "Clone them!")
        {
            int[] currentArray = input
                           .Split(new char[] { ' ', '!' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();

            sampleIndex++;

            int currentLength = LongestSequenceOfOnes(currentArray);
            int currentStartIndex = GetLongestOnesStartIndex(currentArray);
            int currentSum = SumOfOnes(currentArray);

            if (currentLength > bestLength ||
                (currentLength == bestLength && currentStartIndex < bestStartIndex) ||
                (currentLength == bestLength && currentStartIndex == bestStartIndex && currentSum > bestSum))
            {
                bestLength = currentLength;
                bestStartIndex = currentStartIndex;
                bestSum = currentSum;
                bestArray = currentArray;
                bestSampleIndex = sampleIndex;
            }
        }

        Console.WriteLine($"Best DNA sample {bestSampleIndex} with sum: {bestSum}.");
        Console.WriteLine(string.Join(" ", bestArray));
    }

    static int SumOfOnes(int[] array)
    {
        int sum = 0;
        foreach (int number in array)
        {
            if (number == 1)
                sum++;
        }
        return sum;
    }

    static int GetLongestOnesStartIndex(int[] array)
    {
        int maxLength = 0;
        int maxStartIndex = -1;
        int currentLength = 0;
        int currentStart = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 1)
            {
                if (currentLength == 0)
                    currentStart = i;
                    currentLength++;

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxStartIndex = currentStart;
                }
            }
            else
            {
                currentLength = 0;
            }
        }

        return maxStartIndex;
    }

    static int LongestSequenceOfOnes(int[] array)
    {
        int currentSequence = 0;
        int bestSequence = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 1)
            {
                currentSequence++;
                if (currentSequence > bestSequence)
                    bestSequence = currentSequence;
            }
            else
            {
                currentSequence = 0;
            }
        }

        return bestSequence;
    }
}