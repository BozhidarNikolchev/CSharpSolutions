int distanceInMeters = int.Parse(Console.ReadLine());

double totalKilometers = distanceInMeters * 0.001;

Console.WriteLine($"{totalKilometers:f2}");