Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
    .Select(decimal.Parse)
    .Select(n => n * 1.2m)
    .Select(n => $"{n:F2}")
    .ToList()
    .ForEach(n => Console.WriteLine(n));