int pagesCount = int.Parse(Console.ReadLine());
int readPagesInOneHour = int.Parse(Console.ReadLine());
int daysCount = int.Parse(Console.ReadLine());

int totalTimeToReadTheBook = pagesCount / readPagesInOneHour;

int neededHourPerDay = totalTimeToReadTheBook / daysCount;

Console.WriteLine(neededHourPerDay);
