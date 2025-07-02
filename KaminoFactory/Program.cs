int sequencesLength = int.Parse(Console.ReadLine());
string currentSequence;

int bestSumOfOnes = 0;
int bestSequenceNumber = 0;
int indexOfBestSequence = 100;

while ((currentSequence = Console.ReadLine()) != "Clone them!")
{
    int[] currentSequenceToArray = currentSequence.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    bestSequenceNumber++;

    int sumOfOnes = 0;
    foreach (int number in currentSequenceToArray)
    {
        if (number == 1)
        {
            sumOfOnes++;
        }
    }

    int currentIndexOfSequence = 0;
    for (int i = 0; i < currentSequenceToArray.Length; i++)
    {
        if (currentSequenceToArray[i] == 1)
        {
            currentIndexOfSequence += i;
        }
    }

   


    if (sumOfOnes > bestSumOfOnes)
    {
        bestSumOfOnes = sumOfOnes;
        indexOfBestSequence = currentIndexOfSequence;
    }

}

/*
5
1!0!1!1!0
0!1!1!0!0
Clone them!
*/
