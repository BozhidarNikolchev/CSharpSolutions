int ordersCount = int.Parse(Console.ReadLine());

int counterOfOrders = 0;
decimal total = 0;

while (counterOfOrders < ordersCount)
{
    decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsulesCount = int.Parse(Console.ReadLine());

    decimal price = (days * capsulesCount) * pricePerCapsule;
    Console.WriteLine($"The price for the coffee is: ${price:f2}");

    total += price;

    counterOfOrders++;
}

Console.WriteLine($"Total: ${total:f2}");

