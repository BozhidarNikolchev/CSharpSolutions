int counter = int.Parse(Console.ReadLine());

int waterTankCapacity = 255;

int addedLitters = 0;
int result = 0;

for (int i = 0; i < counter; i++)
{
    int littersToAdd = int.Parse(Console.ReadLine());

    addedLitters += littersToAdd;

    if (addedLitters <= waterTankCapacity)
    {
        result = addedLitters;
    }
    else
    {
        if (littersToAdd <= (waterTankCapacity - result))
        {
            result += littersToAdd;
            continue;
        }
        Console.WriteLine("Insufficient capacity!");
        continue;
    }

}

Console.WriteLine(result);