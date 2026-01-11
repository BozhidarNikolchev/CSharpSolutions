int inputLinesCount = int.Parse(Console.ReadLine());

var ageByPerson = new Dictionary<string, int>();
for (int i = 0; i < inputLinesCount; i++)
{
    string[] inputLine = Console.ReadLine()
        .Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

    string name = inputLine[0];
    int age = int.Parse(inputLine[1]);

    ageByPerson.Add(name, age);
}

string condition = Console.ReadLine();
int ageThreshold = int.Parse(Console.ReadLine());
string format = Console.ReadLine();

Predicate<int> checkAge = null!;

if (condition == "younger")
{
    checkAge = age => age < ageThreshold;
}
else if (condition == "older")
{
    checkAge = age => age >= ageThreshold;
}
//else
//{
//    throw new InvalidOperationException("Invalid condition value.");
//}

var filteredByAge = Filtered(ageByPerson, checkAge);

Func<string, int, string> modifiedFormat = null!;

if (format == "name")
{
    modifiedFormat = (name, age) => name;
}
else if (format == "age")
{
    modifiedFormat = (name, age) => age.ToString();
}
else if (format == "name age")
{
    modifiedFormat = (name, age) => $"{name} - {age}";
}
//else
//{
//    throw new InvalidOperationException("Invalid format.");
//}


foreach (var (name, age) in filteredByAge)
{
    var result = modifiedFormat(name, age);
    Console.WriteLine(result);
}


static Dictionary<string, int> Filtered(Dictionary<string, int> dictionary,
        Predicate<int> predicate)
{
    Dictionary<string, int> filteredDictionary = new();

    foreach (var (name, age) in dictionary)
    {
        if (predicate(age))
        {
            filteredDictionary.Add(name, age);
        }
    }

    return filteredDictionary;
}

















