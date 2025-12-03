int pens = int.Parse(Console.ReadLine());
int markers = int.Parse(Console.ReadLine());
int cleaner =  int.Parse(Console.ReadLine());
int discount =  int.Parse(Console.ReadLine());

double convertDiscountIntoPercentage = (double) discount / 100;

double pensPrice = pens * 5.80;
double markersPrice = markers * 7.20;
double cleanerPrice = cleaner * 1.20;

double priceOfAllMaterials = pensPrice + markersPrice + cleanerPrice;

double priceAfterDiscount = priceOfAllMaterials - (priceOfAllMaterials * convertDiscountIntoPercentage);

Console.WriteLine(priceAfterDiscount);
