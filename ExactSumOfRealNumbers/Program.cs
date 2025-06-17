int numbersCount = int.Parse(Console.ReadLine());

decimal sum = 0;

for (int i = 0; i < numbersCount; i++)
{
    decimal currentNum = decimal.Parse(Console.ReadLine());

    sum += currentNum;
}

Console.WriteLine(sum);