int inputNum = int.Parse(Console.ReadLine());

CheckPositiveNegativeOrZero(inputNum);

static void CheckPositiveNegativeOrZero(int number)
{
    if (number > 0)
    {
        Console.WriteLine($"The number {number} is positive.");
    }
    else if (number < 0)
    {
        Console.WriteLine($"The number {number} is negative.");
    }
    else if (number == 0)
    {
        Console.WriteLine($"The number {number} is zero.");
    }
}