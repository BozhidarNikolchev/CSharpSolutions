int[] inputNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

int evenNumbers = 0;
int oddNumbers = 0;

for (int i = 0; i < inputNums.Length; i++)
{
    if (inputNums[i] % 2 == 0)
    {
        evenNumbers += inputNums[i];
    }
    else
    {
        oddNumbers += inputNums[i];
    }
}

Console.WriteLine(evenNumbers - oddNumbers);