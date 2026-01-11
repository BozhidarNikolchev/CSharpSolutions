using System;

int inputLinesCount = int.Parse(Console.ReadLine());

var ageByPerson = new Dictionary<string, int>();
for (int i = 0; i < inputLinesCount; i++)
{
    string[] inputLine = Console.ReadLine()
        .Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

    string name = inputLine[0];
    int age = int.Parse(inputLine[1]);

    if (!ageByPerson.ContainsKey(name))
        ageByPerson[name] = age;
}

string condition = Console.ReadLine();
int ageThreshold = int.Parse(Console.ReadLine());
// Format??? to do 

//List<Person> people = ReadPeople();
//Func<Person, bool> filter = CreateFilter(condition, ageThreshold);
//Action<Person> printer = CreatePrinter(format);
//PrintFilteredPeople(people, filter, printer);










