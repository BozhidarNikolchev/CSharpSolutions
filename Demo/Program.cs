static int[] SwapArrayAccordingToIndex(int[] array, int index)
{
    int[] changedArray = new int[array.Length];
    int currentIndex = 0;

    for (int i = index + 1; i < array.Length; i++)
    {
        changedArray[currentIndex] = array[i];
        currentIndex++;
    }

    for (int i = 0; i <= index; i++)
    {
        changedArray[currentIndex] = array[i];
        currentIndex++;
    }

    return changedArray;
}