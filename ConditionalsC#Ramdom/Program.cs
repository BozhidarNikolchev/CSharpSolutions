string fruit = Console.ReadLine();
string day = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

double result = 0;

switch (fruit)
{
    case "banana":

        switch (day)
        {
            case "Monday":
            case "Tuesday":
            case "Wednesday":
            case "Thursday":
            case "Friday":

                result = quantity * 2.50;
                Console.WriteLine($"{result:f2}");
                break;

            case "Saturday":
            case "Sunday":

                result = quantity * 2.70;
                Console.WriteLine($"{result:f2}");
                break;

            default:
                Console.WriteLine("error");
                break;
        }
        break;

    case "apple":

        switch (day)
        {
            case "Monday":
            case "Tuesday":
            case "Wednesday":
            case "Thursday":
            case "Friday":

                result = quantity * 1.20;
                Console.WriteLine($"{result:f2}");
                break;

            case "Saturday":
            case "Sunday":

                result = quantity * 1.25;
                Console.WriteLine($"{result:f2}");
                break;

            default:
                Console.WriteLine("error");
                break;
        }
        break;

    case "orange":

        switch (day)
        {
            case "Monday":
            case "Tuesday":
            case "Wednesday":
            case "Thursday":
            case "Friday":

                result = quantity * 0.85;
                Console.WriteLine($"{result:f2}");
                break;

            case "Saturday":
            case "Sunday":

                result = quantity * 0.90;
                Console.WriteLine($"{result:f2}");
                break;

            default:
                Console.WriteLine("error");
                break;
        }
        break;

    case "grapefruit":

        switch (day)
        {
            case "Monday":
            case "Tuesday":
            case "Wednesday":
            case "Thursday":
            case "Friday":

                result = quantity * 1.45;
                Console.WriteLine($"{result:f2}");
                break;

            case "Saturday":
            case "Sunday":

                result = quantity * 1.60;
                Console.WriteLine($"{result:f2}");
                break;

            default:
                Console.WriteLine("error");
                break;
        }
        break;

    case "kiwi":

        switch (day)
        {
            case "Monday":
            case "Tuesday":
            case "Wednesday":
            case "Thursday":
            case "Friday":

                result = quantity * 2.70;
                Console.WriteLine($"{result:f2}");
                break;

            case "Saturday":
            case "Sunday":

                result = quantity * 3.00;
                Console.WriteLine($"{result:f2}");
                break;

            default:
                Console.WriteLine("error");
                break;
        }
        break;

    case "pineapple":

        switch (day)
        {
            case "Monday":
            case "Tuesday":
            case "Wednesday":
            case "Thursday":
            case "Friday":

                result = quantity * 5.50;
                Console.WriteLine($"{result:f2}");
                break;

            case "Saturday":
            case "Sunday":

                result = quantity * 5.60;
                Console.WriteLine($"{result:f2}");
                break;

            default:
                Console.WriteLine("error");
                break;
        }
        break;

    case "grapes":

        switch (day)
        {
            case "Monday":
            case "Tuesday":
            case "Wednesday":
            case "Thursday":
            case "Friday":

                result = quantity * 3.85;
                Console.WriteLine($"{result:f2}");
                break;

            case "Saturday":
            case "Sunday":

                result = quantity * 4.20;
                Console.WriteLine($"{result:f2}");
                break;

            default:
                Console.WriteLine("error");
                break;
        }
        break;

    default:
        Console.WriteLine("error");
        break;
}