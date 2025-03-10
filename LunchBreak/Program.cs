using System.Security.Cryptography;

string seriesName = Console.ReadLine();
int episodeDuration = int.Parse(Console.ReadLine());
int breakDuration = int.Parse(Console.ReadLine());

double lunchDuration = (double)breakDuration * 1 / 8;
double restDuration = (double)breakDuration * 1 / 4;

double leftTime = breakDuration - lunchDuration - restDuration;

double diff = Math.Abs(leftTime - episodeDuration);

if (leftTime >= episodeDuration)
{
    Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(diff)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(diff)} more minutes.");
}