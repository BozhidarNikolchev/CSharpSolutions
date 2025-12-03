int lostGamesCount = int.Parse(Console.ReadLine());
decimal headsetPrice = decimal.Parse(Console.ReadLine());
decimal mousePrice = decimal.Parse(Console.ReadLine());
decimal keyboardPrice = decimal.Parse(Console.ReadLine());
decimal displayPrice = decimal.Parse(Console.ReadLine());

int brokenHeadsets = 0;
int brokenMice = 0;
int brokenKeyboards = 0;

for (int i = 1; i <= lostGamesCount; i++)
{
    if (i % 2 == 0)
    {
        brokenHeadsets++;
    }

    if (i % 3 == 0)
    {
        brokenMice++;
    }

    if (i % 6 == 0)
    {
        brokenKeyboards++;
    }


}

int brokenDisplays = brokenKeyboards / 2;

decimal headsetExpenses = brokenHeadsets * headsetPrice;
decimal miceExpenses = brokenMice * mousePrice;
decimal keyboardExpenses = brokenKeyboards * keyboardPrice;
decimal displayExpenses = brokenDisplays * displayPrice;

decimal rageExpenses = headsetExpenses + miceExpenses
    + keyboardExpenses + displayExpenses;

Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");