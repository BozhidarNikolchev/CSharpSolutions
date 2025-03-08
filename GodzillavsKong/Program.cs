double movieBudget = double.Parse(Console.ReadLine());
int extrasCount = int.Parse(Console.ReadLine());
double clothingForAnExtra =  double.Parse(Console.ReadLine());

double decorExpense = movieBudget * 0.10;
double clothingExpense = extrasCount * clothingForAnExtra;

if(extrasCount > 150)
{
    clothingExpense = clothingExpense - (clothingExpense * 0.10);
}

double totalExpenses = decorExpense + clothingExpense;

double difference = Math.Abs(movieBudget - totalExpenses);

if (totalExpenses > movieBudget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {difference:f2} leva more.");
}
else if (totalExpenses <= movieBudget)
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {difference:f2} leva left.");
}