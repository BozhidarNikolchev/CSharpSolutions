int countOfPeople = int.Parse(Console.ReadLine());
string typeOfGroup = Console.ReadLine();
string dayOfStay = Console.ReadLine();

double price = 0;

switch (typeOfGroup)
{
    case "Students":

        if (dayOfStay == "Friday")
        {
            price = countOfPeople * 8.45;
        }
        else if (dayOfStay == "Saturday")
        {
            price = countOfPeople * 9.80;
        }
        else if (dayOfStay == "Sunday")
        {
            price = countOfPeople * 10.46;
        }

        if (countOfPeople >= 30)
        {
            price = price * 0.85;
        }

        break;

    case "Business":

        if (countOfPeople >= 100)
        {
            countOfPeople = countOfPeople - 10;
        }

        if (dayOfStay == "Friday")
        {
            price = countOfPeople * 10.90;
        }
        else if (dayOfStay == "Saturday")
        {
            price = countOfPeople * 15.60;
        }
        else if (dayOfStay == "Sunday")
        {
            price = countOfPeople * 16;
        }

        break;

    case "Regular":

        if (dayOfStay == "Friday")
        {
            price = countOfPeople * 15;
        }
        else if (dayOfStay == "Saturday")
        {
            price = countOfPeople * 20;
        }
        else if (dayOfStay == "Sunday")
        {
            price = countOfPeople * 22.50;
        }

        if (countOfPeople >= 10 && countOfPeople <= 20)
        {
            price = price * 0.95;
        }

        break;
}

Console.WriteLine($"Total price: {price:f2}");

