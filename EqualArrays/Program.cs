using System;

int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

int sumOfElements = 0;
bool areIdentical = false;

for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i] == secondArray[i])
    {
        sumOfElements += firstArray[i];
        areIdentical = true;
    }
    else
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        return;
    }
}

if (areIdentical)
{
    Console.WriteLine($"Arrays are identical. Sum: {sumOfElements}");
}