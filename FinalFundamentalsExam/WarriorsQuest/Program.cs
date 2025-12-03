string skill = Console.ReadLine();

while (true)
{
    string command = Console.ReadLine();

    if (command == "For Azeroth")
    {
        break;
    }

    string[] arguments = command.Split(' ');

    if (arguments[0] == "GladiatorStance")
    {
        skill = ToUpperCase(skill);

        Console.WriteLine(skill);
    }
    else if (arguments[0] == "DefensiveStance")
    {
        skill = ToLowerCase(skill);

        Console.WriteLine(skill);
    }
    else if (arguments[0] == "Dispel")
    {
        if (arguments.Length == 3)
        {
            int index;
            bool isIndex = int.TryParse(arguments[1], out index);

            char letter;
            bool isLetter = char.TryParse(arguments[2], out letter);

            if (isIndex && isLetter && index >= 0 && index < skill.Length)
            {
                char[] chars = skill.ToCharArray();
                chars[index] = letter;
                skill = new string(chars);
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("Dispel too weak.");
            }
        }
        else
        {
            Console.WriteLine("Dispel too weak.");
        }
    }
    else if (arguments[0] == "Target")
    {
        if (arguments.Length >= 3 && arguments[1] == "Change" && arguments.Length == 4)
        {
            string oldStr = arguments[2];
            string newStr = arguments[3];
            if (skill.Contains(oldStr))
            {
                skill = skill.Replace(oldStr, newStr);
                Console.WriteLine(skill);
            }
            else
            {
                Console.WriteLine(skill);
            }
        }
        else if (arguments.Length == 3 && arguments[1] == "Remove")
        {
            string substr = arguments[2];
            if (skill.Contains(substr))
            {
                skill = skill.Replace(substr, "");
                Console.WriteLine(skill);
            }
        }
        else
        {
            Console.WriteLine("Command doesn't exist!");
        }
    }
    else
    {
        Console.WriteLine("Command doesn't exist!");
    }
}

static string ToUpperCase(string s)
{
    string result = "";

    for (int i = 0; i < s.Length; i++)
    {
        result += Char.ToUpper(s[i]);
    }

    return result;
}

static string ToLowerCase(string s)
{
    string result = "";

    for (int i = 0; i < s.Length; i++)
    {
        result += Char.ToLower(s[i]);
    }

    return result;
}
