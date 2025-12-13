using System;
using System.Collections.Generic;
using System.Linq;

var userByForceSide = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);

string command;
while ((command = Console.ReadLine()) != "Lumpawaroo")
{
    string[] data = command.Split(new[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries);
    string user;
    string forceSide;

    if (command.Contains("|"))
    {
        forceSide = data[0];
        user = data[1];

        // Check if user exists in any side (case-insensitive)
        bool userExists = userByForceSide.Values
            .Any(list => list.Any(u => u.Equals(user, StringComparison.OrdinalIgnoreCase)));

        if (!userExists)
        {
            if (!userByForceSide.TryGetValue(forceSide, out var list))
            {
                list = new List<string>();
                userByForceSide[forceSide] = list;
            }

            // Avoid duplicates in the list
            if (!list.Any(u => u.Equals(user, StringComparison.OrdinalIgnoreCase)))
            {
                list.Add(user);
            }
        }
    }
    else if (command.Contains("->"))
    {
        user = data[0];
        forceSide = data[1];

        bool userExists = userByForceSide.Values
            .Any(list => list.Any(u => u.Equals(user, StringComparison.OrdinalIgnoreCase)));

        if (userExists)
        {
            // Remove user from whatever side they're currently in
            foreach (var kvp in userByForceSide)
            {
                var currentUserList = kvp.Value;
                int idx = currentUserList.FindIndex(u => u.Equals(user, StringComparison.OrdinalIgnoreCase));
                if (idx >= 0)
                {
                    currentUserList.RemoveAt(idx);
                    break;
                }
            }
        }

        // Ensure destination side exists
        if (!userByForceSide.TryGetValue(forceSide, out var destList))
        {
            destList = new List<string>();
            userByForceSide[forceSide] = destList;
        }

        // Add user to destination side if not already there
        if (!destList.Any(u => u.Equals(user, StringComparison.OrdinalIgnoreCase)))
        {
            destList.Add(user);
        }

        Console.WriteLine($"{user} joins the {forceSide} side!");
    }
}

// Sort users within each side (alphabetical, case-insensitive)
foreach (var list in userByForceSide.Values)
{
    list.Sort(StringComparer.OrdinalIgnoreCase);
}

// Order sides by member count desc, then by side name
var orderedSideByUser = userByForceSide
    .OrderByDescending(kvp => kvp.Value.Count)
    .ThenBy(kvp => kvp.Key, StringComparer.OrdinalIgnoreCase);

foreach (var kvp in orderedSideByUser)
{
    var forceSide = kvp.Key;
    var forceUserList = kvp.Value;

    if (forceUserList.Any())
    {
        Console.WriteLine($"Side: {forceSide}, Members: {forceUserList.Count}");
        foreach (var u in forceUserList)
        {
            Console.WriteLine($"! {u}");
        }
    }
}