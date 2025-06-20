string[] daysOfWeek = {
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday" };

int inputNumber = int.Parse(Console.ReadLine());
string output = "";

switch (inputNumber)
{
    case 1:
        output = daysOfWeek[0];
        break;

    case 2:
        output = daysOfWeek[1];
        break;

    case 3:
        output = daysOfWeek[2];
        break;

    case 4:
        output = daysOfWeek[3];
        break;

    case 5:
        output = daysOfWeek[4];
        break;

    case 6:
        output = daysOfWeek[5];
        break;

    case 7:
        output = daysOfWeek[6];
        break;

    default:
        output = "Invalid day!";
        break;
}

Console.WriteLine(output);