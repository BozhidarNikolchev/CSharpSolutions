double excursionPrice = double.Parse(Console.ReadLine());
int puzzelsCount = int.Parse(Console.ReadLine());
int talkingDollsCount = int.Parse(Console.ReadLine());
int teddyBearsCount = int.Parse(Console.ReadLine());
int minionsCount = int.Parse(Console.ReadLine());
int trucksCount = int.Parse(Console.ReadLine());

double toysPrice = (puzzelsCount * 2.60) + (talkingDollsCount * 3)
    + (teddyBearsCount * 4.10) + (minionsCount * 8.20)
    + (trucksCount * 2);

int countOfToys = puzzelsCount + talkingDollsCount + teddyBearsCount
    + minionsCount + trucksCount;

if (countOfToys >= 50)
{
    toysPrice = toysPrice - (toysPrice * 0.25);
}

double finalToysPrice = toysPrice - (toysPrice * 0.10);

double difference = Math.Abs(excursionPrice - finalToysPrice);

if (finalToysPrice >= excursionPrice)
{
    Console.WriteLine($"Yes! {difference:f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {difference:f2} lv needed.");
}