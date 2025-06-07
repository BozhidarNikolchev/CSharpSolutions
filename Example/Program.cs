double amountOfmoney = double.Parse(Console.ReadLine());
int countOfStudents = int.Parse(Console.ReadLine());
double priceOfOneLightSaber = double.Parse(Console.ReadLine());
double priceOfOneRobe = double.Parse(Console.ReadLine());
double priceOfOneBelt = double.Parse(Console.ReadLine());

double lightSabersPrice = priceOfOneLightSaber * countOfStudents;
double additionalLigthSabersPrice = priceOfOneLightSaber * Math.Ceiling(countOfStudents + (countOfStudents * 0.10));

double robesPrice = priceOfOneRobe * countOfStudents;

int freeBelts = 0;
for (int i = 1; i <= countOfStudents; i++)
{
    if (i % 6 == 0)
    {
        freeBelts++;
    }
}

double beltsTotalPrice = priceOfOneBelt * (countOfStudents - freeBelts);

double padawanPrice = additionalLigthSabersPrice + robesPrice + beltsTotalPrice;

if (padawanPrice <= amountOfmoney)
{
    Console.WriteLine($"The money is enough - it would cost {padawanPrice:f2}lv.");
}
else
{
    double neededMoney = Math.Abs(amountOfmoney - padawanPrice);
    Console.WriteLine($"John will need {neededMoney:f2}lv more.");
}

