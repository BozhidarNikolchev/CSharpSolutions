int usernamesCount = int.Parse(Console.ReadLine());

var uniqueUsers = new HashSet<string>();

for (int i = 0; i < usernamesCount; i++)
{
    string currentUser = Console.ReadLine();

    uniqueUsers.Add(currentUser);
}

foreach (var username in uniqueUsers)
{
    Console.WriteLine(username);
}