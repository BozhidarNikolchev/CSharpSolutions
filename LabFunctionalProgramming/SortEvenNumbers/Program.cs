var numbers = Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
    .Select(int.Parse)
    .Where(n => n % 2 == 0)
    .OrderBy(n => n)
    .ToList();

Console.WriteLine(string.Join(", ", numbers));




