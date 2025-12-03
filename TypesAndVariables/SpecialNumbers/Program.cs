int inputNum = int.Parse(Console.ReadLine());

for (int i = 1; i <= inputNum; i++)
{
    int sum = digitsSum(i);

    if (sum == 5 || sum == 7 || sum == 11)
    {
        Console.WriteLine($"{i} -> True");
    }
    else
    {
        Console.WriteLine($"{i} -> False");
    }
}

static int digitsSum(int number)
{
    int sum = 0;

    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }

    return sum;
}



