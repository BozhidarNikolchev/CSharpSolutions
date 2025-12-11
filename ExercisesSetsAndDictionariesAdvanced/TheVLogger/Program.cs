var vloggersInfo = new Dictionary<string, (HashSet<string>followers, HashSet<string>following)>();

string command = string.Empty;
while ((command = Console.ReadLine()) != "Statistics")
{
    string[] action = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string vloggerName = action[0];
    string idol;

    if (action.Length == 4 && action[1] == "joined")
    {
        if (!vloggersInfo.ContainsKey(vloggerName))
            vloggersInfo[vloggerName] = (new HashSet<string>(), new HashSet<string>());
        // vloggersInfo[vloggerName] = (followers: [], following: []);
    }

    if (action.Length == 3 && action[1] == "followed")
    {
        idol = action[2];
        if (vloggersInfo.ContainsKey(vloggerName) && vloggersInfo.ContainsKey(idol)
                                                  && vloggerName != idol)
        {
            vloggersInfo[vloggerName].following.Add(idol);
            vloggersInfo[idol].followers.Add(vloggerName);
        }
    }
}

Console.WriteLine($"The V-Logger has a total of {vloggersInfo.Count} vloggers in its logs.");

int order = 1;
foreach ((string vlogger, (HashSet<string> followers, HashSet<string> following)) in vloggersInfo
             .OrderByDescending(x => x.Value.followers.Count)
             .ThenBy(x => x.Value.following.Count))
{
    Console.WriteLine($"{order}. {vlogger} : {followers.Count} followers, {following.Count} following");

    if (order == 1)
    {
        foreach (string follower in followers.Order())
        {
            Console.WriteLine($"*  {follower}");
        }
    }

    order++;
}