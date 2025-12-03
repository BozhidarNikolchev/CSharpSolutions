using System;
using System.Collections;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int maxCount = 0;
        int maxNumber = inputNumbers[0];
        int currentCount = 1;

        for (int i = 1; i < inputNumbers.Length; i++)
        {
            if (inputNumbers[i] == inputNumbers[i - 1])
            {
                currentCount++;
            }
            else
            {
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    maxNumber = inputNumbers[i - 1];
                }
                currentCount = 1;
            }
        }

        // Check the last sequence
        if (currentCount > maxCount)
        {
            maxCount = currentCount;
            maxNumber = inputNumbers[inputNumbers.Length - 1];
        }

        // Print the result
        for (int i = 0; i < maxCount; i++)
        {
            Console.Write(maxNumber + " ");
        }
    }
}