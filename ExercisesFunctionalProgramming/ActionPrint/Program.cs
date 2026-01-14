string[] inputStrings = Console.ReadLine().Split();

PrintStrings(inputStrings, word => Console.WriteLine(word));

static void PrintStrings(string[] array, Action<string> action)
{
    foreach (string word in array)
    {
        action(word);
    }
}