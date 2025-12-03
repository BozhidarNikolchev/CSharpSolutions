int inputNumber = int.Parse(Console.ReadLine());

int result = 0;

if (inputNumber % 10 == 0)
{
    result = 10;
}
else if (inputNumber % 7 == 0)
{
    result = 7;
}
else if (inputNumber % 6 == 0)
{
    result = 6;
}
else if (inputNumber % 3 == 0)
{
    result = 3;
}
else if (inputNumber % 2 == 0)
{
    result = 2;
}
else
{
    Console.WriteLine("Not divisible");
    return;
}

Console.WriteLine($"The number is divisible by {result}");