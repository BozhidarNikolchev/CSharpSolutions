string typeOfDay = Console.ReadLine();
int ageOfPerson = int.Parse(Console.ReadLine());

string singleTicketPrice = "";

switch (typeOfDay)
{
    case "Weekday":

        if (ageOfPerson >= 0 && ageOfPerson <= 18)
        {
            singleTicketPrice = "12$";
        }
        else if (ageOfPerson > 18 && ageOfPerson <= 64)
        {
            singleTicketPrice = "18$";
        }
        else if (ageOfPerson > 64 && ageOfPerson <= 122)
        {
            singleTicketPrice = "12$";
        }
        else
        {
            singleTicketPrice = "Error!";
        }
        break;

    case "Weekend":

        if (ageOfPerson >= 0 && ageOfPerson <= 18)
        {
            singleTicketPrice = "15$";
        }
        else if (ageOfPerson > 18 && ageOfPerson <= 64)
        {
            singleTicketPrice = "20$";
        }
        else if (ageOfPerson > 64 && ageOfPerson <= 122)
        {
            singleTicketPrice = "15$";
        }
        else
        {
            singleTicketPrice = "Error!";
        }
        break;

    case "Holiday":

        if (ageOfPerson >= 0 && ageOfPerson <= 18)
        {
            singleTicketPrice = "5$";
        }
        else if (ageOfPerson > 18 && ageOfPerson <= 64)
        {
            singleTicketPrice = "12$";
        }
        else if (ageOfPerson > 64 && ageOfPerson <= 122)
        {
            singleTicketPrice = "10$";
        }
        else
        {
            singleTicketPrice = "Error!";
        }
        break;
}

Console.WriteLine(singleTicketPrice);