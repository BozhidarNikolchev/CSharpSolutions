int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int targetNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < inputNumbers.Length - 1; i++)
{
    for (int j = i + 1; j < inputNumbers.Length; j++)
    {
        if (inputNumbers[i] + inputNumbers[j] == targetNumber)
        {
            Console.WriteLine($"{inputNumbers[i]} {inputNumbers[j]}");
        }
    }
}