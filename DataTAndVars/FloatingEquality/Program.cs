double firstNum = double.Parse(Console.ReadLine());
double secondNum = double.Parse(Console.ReadLine());

double eps = 0.000001;
bool areEqual = Math.Abs(firstNum - secondNum) < eps;

Console.WriteLine(areEqual);