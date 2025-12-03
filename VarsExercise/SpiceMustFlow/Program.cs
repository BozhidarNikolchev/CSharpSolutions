int startingYield = int.Parse(Console.ReadLine());

int days = 0;
int resultYield = 0;

while (startingYield >= 100)
{
    resultYield += startingYield;
    startingYield -= 10;
    days++;
    resultYield -= 26; 
}

if (resultYield >= 26)
{
    resultYield -= 26;
}
else
{
    resultYield = 0;
}

Console.WriteLine($"{days}\n{resultYield}");
