decimal britishPound = decimal.Parse(Console.ReadLine());

decimal currencyCourse = 1.31M;
decimal poundToDollar = britishPound * currencyCourse;

Console.WriteLine($"{poundToDollar:F3}");