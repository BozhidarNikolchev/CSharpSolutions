string userName = Console.ReadLine();

for (int i = 0; i < 4; i++)
{
    string password = Console.ReadLine();

    char[] charArray = password.ToCharArray();
    Array.Reverse(charArray);
    string reversedPassword = new string(charArray);

    if (reversedPassword == userName)
    {
        Console.WriteLine($"User {userName} logged in.");
        return;
    }

    if (i == 3)
    {
        Console.WriteLine($"User {userName} blocked!");
        return;
    }

    if (reversedPassword != userName)
    {
        Console.WriteLine("Incorrect password. Try again.");
    }

}