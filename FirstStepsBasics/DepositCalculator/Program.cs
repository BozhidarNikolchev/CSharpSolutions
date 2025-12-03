double depositedSum = double.Parse(Console.ReadLine());
int depositPeriodInMonths = int.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine());

double annualInterestRateInPercents = annualInterestRate / 100;

double interest = depositedSum * annualInterestRateInPercents;
double interestForOneMonth = interest / 12;
double totalSum = depositedSum + depositPeriodInMonths * interestForOneMonth;

Console.WriteLine(totalSum);
