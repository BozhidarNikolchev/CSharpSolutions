int number = int.Parse(Console.ReadLine());
int multiplicator = int.Parse(Console.ReadLine());

int result;

if (multiplicator <= 10)
{
    for (int i = multiplicator; i <= 10; i++)
    {
        result = number * i;
        Console.WriteLine($"{number} X {i} = {result}");
    }
}
else
{
    result = number * multiplicator;
    Console.WriteLine($"{number} X {multiplicator} = {result}");
}

