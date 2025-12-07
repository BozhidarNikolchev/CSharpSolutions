int namesCount = int.Parse(Console.ReadLine());

var uniqueNames = new HashSet<string>();

for (int i = 0; i < namesCount; i++)
{
    string currentName = Console.ReadLine();

    if (currentName.GetType() != typeof(string))
    {
        Console.WriteLine("Invalid name");
        continue;
    }

    uniqueNames.Add(currentName);
}

foreach (string name in uniqueNames)
{
    Console.WriteLine(name);
}