string product = Console.ReadLine();
int quantity = Convert.ToInt32(Console.ReadLine());

CalculateTotalPriceOfProduct(product, quantity);

static void CalculateTotalPriceOfProduct(string product, int quantity)
{
    double totalPrice = 0.0;

    switch (product)
    {
        case "coffee":
            totalPrice = quantity * 1.50;
            break;

        case "water":
            totalPrice = quantity * 1.00;
            break;

        case "coke":
            totalPrice = quantity * 1.40;
            break;

        case "snacks":
            totalPrice = quantity * 2.00;
            break;
    }

    Console.WriteLine($"{totalPrice:F2}");
}