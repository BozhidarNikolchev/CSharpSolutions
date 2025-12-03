int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int maxSequence = 1;
int currentSequence = 1;
int maxNumber = inputNumbers[0];

for (int i = 1; i < inputNumbers.Length; i++)
{
    if (inputNumbers[i] == inputNumbers[i - 1])
    {
        currentSequence++;

        if (currentSequence > maxSequence)
        {
            maxSequence = currentSequence;
            maxNumber = inputNumbers[i];
        }
    }
    else
    {
        currentSequence = 1;
    }
}

for (int i = 0; i < maxSequence; i++)
{
    Console.Write(maxNumber + " ");
}