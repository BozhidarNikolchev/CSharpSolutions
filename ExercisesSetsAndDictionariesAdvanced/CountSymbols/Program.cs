string text = Console.ReadLine();

var counterByLetter = new Dictionary<char, int>();

for (int i = 0; i < text.Length; i++)
{
    if (!counterByLetter.ContainsKey(text[i]))
    {
        counterByLetter[text[i]] = 0;
    }

    counterByLetter[text[i]]++;
}

foreach (var kvp in counterByLetter.OrderBy(kvp => kvp.Key))
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
}