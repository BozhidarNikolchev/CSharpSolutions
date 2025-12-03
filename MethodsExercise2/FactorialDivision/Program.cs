int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());

double firstNumFactorial = CalculateFactorial(firstNum);
double secondNumFactorial = CalculateFactorial(secondNum);

double result = firstNumFactorial / secondNumFactorial;
Console.WriteLine($"{result:F2}");
static double CalculateFactorial(int number)
{
    double factorial = 1;

    for (int i = 2; i <= number; i++)
    {
        factorial *= i;
    }

    return factorial;
}