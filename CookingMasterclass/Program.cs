double budget = double.Parse(Console.ReadLine());
int studentsCount = int.Parse(Console.ReadLine());
double packageOfFlourPrice = double.Parse(Console.ReadLine());
double singleEggPrice = double.Parse(Console.ReadLine());
double singleApronPrice = double.Parse(Console.ReadLine());

int additionalAprons = (int)Math.Ceiling(studentsCount * 1.20);

int freePackagesOfFlour = studentsCount / 5;
int paidFlourPackages = studentsCount - freePackagesOfFlour;
double flourTotalPrice = paidFlourPackages * packageOfFlourPrice;

double eggsTotalPrice = studentsCount * 10 * singleEggPrice;
double apronTotalPrice = additionalAprons * singleApronPrice;

double finalPrice = flourTotalPrice + eggsTotalPrice + apronTotalPrice;

if (finalPrice <= budget)
{
    Console.WriteLine($"Items purchased for {finalPrice:f2}$.");
}
else
{
    double neededMoney = finalPrice - budget;
    Console.WriteLine($"{neededMoney:f2}$ more needed.");
}
