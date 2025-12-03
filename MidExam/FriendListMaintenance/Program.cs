List<string> allFriends = Console.ReadLine().Split(", ").ToList();

List<string> blacklisted = new List<string>();
List<string> lost = new List<string>();

while (true)
{
    string[] currentCommand = Console.ReadLine().Split();
    string command = currentCommand[0];

    if (command == "Report")
    {
        Console.WriteLine($"Blacklisted names: {blacklisted.Count}");
        Console.WriteLine($"Lost names: {lost.Count}");
        Console.WriteLine(string.Join(" ", allFriends));
        break;
    }
    else if (command == "Blacklist")
    {
        string nameToBlacklist = currentCommand[1];
        int index = allFriends.IndexOf(nameToBlacklist);
        if (index != -1)
        {
            allFriends[index] = "Blacklisted";
            blacklisted.Add(nameToBlacklist);
            Console.WriteLine($"{nameToBlacklist} was blacklisted.");
        }
        else
        {
            Console.WriteLine($"{nameToBlacklist} was not found.");
        }
    }
    else if (command == "Error")
    {
        int index = int.Parse(currentCommand[1]);
        if (index >= 0 && index < allFriends.Count)
        {
            string name = allFriends[index];
            if (name != "Blacklisted" && name != "Lost")
            {
                Console.WriteLine($"{name} was lost due to an error.");
                lost.Add(name);
                allFriends[index] = "Lost";
            }
        }
    }
    else if (command == "Change")
    {
        int index = int.Parse(currentCommand[1]);
        string newName = currentCommand[2];
        if (index >= 0 && index < allFriends.Count)
        {
            Console.WriteLine($"{allFriends[index]} changed his username to {newName}.");
            allFriends[index] = newName;
        }
    }
}
