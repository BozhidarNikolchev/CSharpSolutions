int chickenMenusCount = int.Parse(Console.ReadLine());
int fishMenusCount = int.Parse(Console.ReadLine());
int vegetarianMenusCount = int.Parse(Console.ReadLine());

double priceOfMenus = (chickenMenusCount * 10.35) + (fishMenusCount * 12.40) + (vegetarianMenusCount * 8.15);

double totalBil = priceOfMenus + (priceOfMenus * 0.20) + 2.50;

Console.WriteLine(totalBil);