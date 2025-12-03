double number = Convert.ToDouble(Console.ReadLine());
int power = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CalculateNumberToThePower(number, power));
static double CalculateNumberToThePower(double number, int power)
{
    double result = Math.Pow(number, power);
    return result;
}