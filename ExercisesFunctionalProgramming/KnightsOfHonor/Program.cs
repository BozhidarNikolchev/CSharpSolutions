string[] inputNames = Console.ReadLine().Split();

PrintNames(inputNames, word => Console.WriteLine($"Sir {word}"));

static void PrintNames(string[] array, Action<string> action)
{
    foreach (string word in array)
    {
        action(word);
    }
}