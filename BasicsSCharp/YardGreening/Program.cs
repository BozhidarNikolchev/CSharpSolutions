double squareMeters = double.Parse(Console.ReadLine());

double calcGreeningPrice = squareMeters * 7.61;
double discount = calcGreeningPrice * 0.18;

double greeningPriceAfterDiscount = calcGreeningPrice - discount;

Console.WriteLine($"The final price is: {greeningPriceAfterDiscount} lv.\nThe discount is: {discount} lv.");
