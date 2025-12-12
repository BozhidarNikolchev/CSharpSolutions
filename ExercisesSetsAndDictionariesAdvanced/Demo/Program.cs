string firstcommand = string.Empty;
while ((firstcommand = Console.ReadLine()) != "end of contests")
{
    string[] contestPasswords = firstcommand
        .Split(':');
    string validContest = contestPasswords[0];
    string validPassword = contestPasswords[1];

    Console.WriteLine(validContest);
    Console.WriteLine(validPassword);
}