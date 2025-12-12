var passwordByContest = new Dictionary<string, HashSet<string>>();
var userInfo = new Dictionary<string, List<Dictionary<string, int>>>();

string firstcommand = string.Empty;
while ((firstcommand = Console.ReadLine()) != "end of contests")
{
    string[] contestPasswords = firstcommand
        .Split(':');
    string validContest = contestPasswords[0];
    string validPassword = contestPasswords[1];

    if (!passwordByContest.ContainsKey(validContest))
    {
        passwordByContest[validContest] = new HashSet<string>();
    }

    passwordByContest[validContest].Add(validPassword);
}

string secondCommand = string.Empty;
while ((secondCommand = Console.ReadLine()) != "end of submissions")
{
    string[] inputData = secondCommand
        .Split("=>");

    string contest = inputData[0];
    string password = inputData[1];
    string user = inputData[2];
    int points = int.Parse(inputData[3]);

    if (passwordByContest.ContainsKey(contest)
        && passwordByContest[contest].Contains(password))
    {
        if (!userInfo.ContainsKey(user))
        {
            userInfo[user] = new List<Dictionary<string, int>>();
            userInfo[user].Add(new Dictionary<string, int>
            {
                [contest] = points
            });
        }
        else
        {
            if (!userInfo[user].Any(dict => dict.ContainsKey(contest)))
            {
                userInfo[user].Add(new Dictionary<string, int>
                {
                    [contest] = points
                });
            }
            else 
            {
                var existingContest = userInfo[user]
                    .FirstOrDefault(d => d.ContainsKey(contest));

                int existingPointsForContest = existingContest[contest];

                if (existingPointsForContest < points)
                {
                    existingContest[contest] = points;
                }
            }
        }
    }
}

var bestUser = userInfo.OrderByDescending(u => u.Value
    .SelectMany(d => d.Values).Sum()).First();

var bestUserPoints = bestUser.Value.SelectMany(d => d.Values).Sum();

Console.WriteLine($"Best candidate is {bestUser.Key} with total {bestUserPoints} points.");
Console.WriteLine("Ranking: ");

foreach (KeyValuePair<string, List<Dictionary<string, int>>> entry in userInfo
             .OrderBy(u => u.Key))
{
    string user = entry.Key;
    List<Dictionary<string, int>> contests = entry.Value;

    Console.WriteLine(user);

    foreach (var currentContest in contests.OrderByDescending(c => c.Values.Max()))
    {
        foreach (var kvp in currentContest)
        {
            Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
        }
    }
}

