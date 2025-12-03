double recordInSeconds = double.Parse(Console.ReadLine());
double distanceInMeters =  double.Parse(Console.ReadLine());
double timeInSecondsForOneMeter =  double.Parse(Console.ReadLine());

double calcDistanceAndTime = distanceInMeters * timeInSecondsForOneMeter;
double everyFifteenMetersSlowdown = Math.Floor(distanceInMeters / 15);
double totalSlowdown = everyFifteenMetersSlowdown * 12.5;
double totalTime = calcDistanceAndTime + totalSlowdown;

if (totalTime < recordInSeconds)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
}
else if (totalTime >= recordInSeconds)
{
    double diff = totalTime - recordInSeconds;
    Console.WriteLine($"No, he failed! He was {diff:f2} seconds slower.");
}
