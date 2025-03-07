int score = int.Parse(Console.ReadLine());

double bonus = 0.0;

if  (score <= 100)
{
    bonus = 5;
}
else if (score <= 1000)
{
    bonus = score * 0.20;
}
else
{
    bonus = score * 0.10;
}

if (score % 2 == 0)
{
    bonus += 1;
}

if (score % 10 == 5)
{
    bonus += 2;
}

Console.WriteLine($"{bonus}\n{score + bonus}");