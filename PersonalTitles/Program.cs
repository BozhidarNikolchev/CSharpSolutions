double age = double.Parse(Console.ReadLine());
char gender = char.Parse(Console.ReadLine());

string output = "";

if (age < 16)
{
    if (gender == 'm')
        output = "Master";

    else if (gender == 'f')
        output = "Miss";

}
else
{
    if (gender == 'm')
        output = "Mr.";

    else if (gender == 'f')
        output = "Ms.";

}

Console.WriteLine(output);