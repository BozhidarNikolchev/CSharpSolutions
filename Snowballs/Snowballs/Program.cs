int numberOfSnowballs = int.Parse(Console.ReadLine());

if (numberOfSnowballs <= 0)
{
    Console.WriteLine("Number of snowballs must be greater than 0!");
    return;
}

int maxValue = int.MinValue;
int[] maxNumbers = new int[3];
bool foundValid = false;

for (int i = 0; i < numberOfSnowballs; i++)
{
    int[] currentNumbers = new int[3];

    for (int j = 0; j < 3; j++)
    {
        currentNumbers[j] = int.Parse(Console.ReadLine());
    }

    int snow = currentNumbers[0];
    int time = currentNumbers[1];
    int quality = currentNumbers[2];

    if (time <= 0)
    {
        Console.WriteLine("Time cannot be zero or negative!");
        continue;
    }

    double result = Math.Pow((double)snow / time, quality);

    if (result > int.MaxValue)
    {
        result = int.MaxValue;
        Console.WriteLine("Value is bigger than int.MaxValue");
    }

    int value = (int)result;

    if (value > maxValue)
    {
        maxValue = value;
        Array.Copy(currentNumbers, maxNumbers, 3);
        foundValid = true;
    }
}

if (foundValid)
{
    Console.WriteLine($"{maxNumbers[0]} : {maxNumbers[1]} = {maxValue} ({maxNumbers[2]})");
}
else
{
    Console.WriteLine("No valid snowballs were entered.");
}
