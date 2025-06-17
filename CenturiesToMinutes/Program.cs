int century = int.Parse(Console.ReadLine());

int centuryToYears = century * 100;
double yearsToDays = Math.Truncate(centuryToYears * 365.2422);
double daysToHours = yearsToDays * 24;
double hoursToMinutes = daysToHours * 60;

Console.WriteLine($"{century} centuries = {centuryToYears} years = {yearsToDays} days = {daysToHours} hours = {hoursToMinutes} minutes");