using System;

var shops = new SortedDictionary<string, Dictionary<string, double>>();

while (true)
{
    string command = Console.ReadLine();

    if (command == "Revision")
    {
        break;
    }
    else
    {
        string[] currentShopInfo = command.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        if (currentShopInfo.Length != 3)
        {
            Console.WriteLine("Invalid Input");
            continue;
        }
        string shopName = currentShopInfo[0];
        string productName = currentShopInfo[1];
        double productPrice = double.Parse(currentShopInfo[2]);

        if (!shops.ContainsKey(shopName))
        {
            shops[shopName] = new Dictionary<string, double>();
        }

        shops[shopName].Add(productName, productPrice);
    }
}

foreach (var (shop, products) in shops)
{
    Console.WriteLine($"{shop}->");

    foreach (var (product, price) in products)
    {
        Console.WriteLine($"Product: {product}, Price: {price}");
    }
}