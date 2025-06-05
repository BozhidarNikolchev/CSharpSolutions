int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int hoursToMinutes = 0;

if (hours != 0)
{
    hoursToMinutes = hours * 60;
}

int totalTimeInMinutes = hoursToMinutes + minutes + 30;

int totalHours = totalTimeInMinutes / 60;
int totalMinutes = totalTimeInMinutes % 60;

if (totalHours == 24)
{
    totalHours = 0;
}

if (totalMinutes < 10)
{
    Console.WriteLine($"{totalHours}:0{totalMinutes}");
}
else
{
    Console.WriteLine($"{totalHours}:{totalMinutes}");
}

