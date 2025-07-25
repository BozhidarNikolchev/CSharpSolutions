double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());

double distance1 = CalculateDistanceFromZero(x1, y1);
double distance2 = CalculateDistanceFromZero(x2, y2);

if (distance1 < distance2)
{
    Console.WriteLine($"({x1}, {y1})");
}
else if (distance2 < distance1)
{
    Console.WriteLine($"({x2}, {y2})");
}
else if (distance1 == distance2)
{
    Console.WriteLine($"({x1}, {y1})");
}

static double CalculateDistanceFromZero(double x, double y)
{
    return Math.Sqrt(x * x + y * y);
}
