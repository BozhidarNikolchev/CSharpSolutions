// how to calc the index of the first element in a sequence of identical elements in array

int[] array = { 9, 2, 9, 1, 1, 1, 5, 6, 7 };

int currentLength = 0;
int maxLength = 0;
int currentStartIndex = 0;
int startIndex = -1;

for (int i=0; i < array.Length; i++)
{
    if (array[i] == 1)
    {
        if (currentLength == 0)
        {
            currentLength++;
            currentStartIndex = i;

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                startIndex = currentStartIndex;
            }
        }
        else
        {
            currentLength = 0;
        }
    }
}


Console.WriteLine(startIndex);