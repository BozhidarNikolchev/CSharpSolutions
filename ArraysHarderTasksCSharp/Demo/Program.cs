//int[] array = { 1, 2, 3, 4 };
//Array.Resize(ref array, array.Length - 1);
//Console.WriteLine(string.Join("", array));


int[] array = { 1, 1, 1, 1, 1 };

int sum = 0;

for (int i = 0; i < array.Length - 1; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] == array[j])
        {
            sum++;
        }
        else
        {
            break;
        }
    }

    sum = 0;
    
}

Console.WriteLine(sum);