int numberOfEntries = int.Parse(Console.ReadLine());

var continents = new Dictionary<string, Dictionary<string, List<string>>>();

for (int i = 0; i < numberOfEntries; i++)
{
    string? inputCommand = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(inputCommand))
    {
        Console.WriteLine("Invalid input");
        continue;
    }

    string[] command = inputCommand
        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
        .ToArray();

    if (command.Length != 3)
    {
        Console.WriteLine("Input is not correct");
        continue;
    }

    string continent = command[0];
    string country = command[1];
    string city = command[2];

    if (!continents.ContainsKey(continent))
    {
        continents[continent] = new Dictionary<string, List<string>>();
    }

    var currentContinent = continents[continent];

    if (!currentContinent.ContainsKey(country))
    {
        currentContinent[country] = new List<string>();
    }

    var currentCountry = currentContinent[country];

    currentCountry.Add(city);
}

foreach (var (continent, countries) in continents)
{
    Console.WriteLine($"{continent}:");

    foreach (var (country, cities) in countries)
    {
        var formattedCities = string.Join(", ", cities);

        Console.WriteLine($"  {country} -> {formattedCities}");
    }
}