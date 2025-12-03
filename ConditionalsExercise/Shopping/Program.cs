double budget = double.Parse(Console.ReadLine());
int videoCards = int.Parse(Console.ReadLine());
int proccessors =  int.Parse(Console.ReadLine());
int ramMemory = int.Parse(Console.ReadLine());

int priceVideoCards = videoCards * 250;
double priceProccessors = (priceVideoCards * 0.35) * proccessors;
double priceRamMemory = (priceVideoCards * 0.10) * ramMemory;

double totalPrice = priceVideoCards + priceProccessors + priceRamMemory;

if (videoCards > proccessors)
{
    totalPrice = totalPrice - (totalPrice * 0.15);
}

double diff = Math.Abs(totalPrice - budget);
if (budget >= totalPrice)
{
    Console.WriteLine($"You have {diff:f2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {diff:f2} leva more!");
}