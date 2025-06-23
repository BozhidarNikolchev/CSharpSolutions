int initialPower = int.Parse(Console.ReadLine());
int targetDistance = int.Parse(Console.ReadLine());
int exhaustionFactor = int.Parse(Console.ReadLine());

int originalValue = initialPower;
int pokedTargetsCount = 0;

while (initialPower >= targetDistance)
{
    if (initialPower == originalValue / 2)
    {
        if (exhaustionFactor != 0)
        {
            initialPower /= exhaustionFactor;

            if (initialPower < targetDistance)
            {
                break;
            }
        }

    }

        initialPower -= targetDistance;
        pokedTargetsCount++;
}

Console.WriteLine($"{initialPower}\n{pokedTargetsCount}");