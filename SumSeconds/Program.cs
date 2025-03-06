int firstCompetitor = int.Parse(Console.ReadLine());
int secondCompetitor = int.Parse(Console.ReadLine());
int thirdCompetitor = int.Parse(Console.ReadLine());

int totalSeconds = firstCompetitor + secondCompetitor + thirdCompetitor;

int minutes = totalSeconds / 60;
int seconds = totalSeconds % 60;

if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}