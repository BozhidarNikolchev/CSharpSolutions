double currentBalance = double.Parse(Console.ReadLine());

string currentGame;
double spentMoney = 0;
double price = 0;

while ((currentGame = Console.ReadLine()) != "Game Time")
{
    switch (currentGame)
    {
        case "OutFall 4":
            price = 39.99;
            break;

        case "CS: OG":
            price = 15.99;
            break;

        case "Zplinter Zell":
            price = 19.99;
            break;

        case "Honored 2":
            price = 59.99;
            break;

        case "RoverWatch":
            price = 29.99;
            break;

        case "RoverWatch Origins Edition":
            price = 39.99;
            break;

        default:
            Console.WriteLine("Not Found");
            continue;
    }

    if (currentBalance >= price)
    {
        currentBalance -= price;
        spentMoney += price;
        Console.WriteLine($"Bought {currentGame}");
    }
    else if (currentBalance == 0)
    {
        Console.WriteLine("Out of money!");
        return;
    }
    else if (currentBalance < price)
    {
        Console.WriteLine("Too Expensive");
    }
}

if (currentBalance == 0)
{
    Console.WriteLine("Out of money!");
}
else
{
    Console.WriteLine($"Total spent: ${spentMoney:f2}. Remaining: ${currentBalance:f2}");
}
