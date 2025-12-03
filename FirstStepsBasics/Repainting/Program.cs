int nylonInSqMeters = int.Parse(Console.ReadLine());
int paintInLiters = int.Parse(Console.ReadLine());
int thinnerInLiters = int.Parse(Console.ReadLine());
int neededHours = int.Parse(Console.ReadLine());

double additionalPaint = paintInLiters + (paintInLiters * 0.10);

double priceForNylon = (nylonInSqMeters + 2) * 1.50;
double priceForPaint = additionalPaint * 14.50;
double priceForThinner = thinnerInLiters * 5.00; // here!
double bags = 0.40;

double totalSumForMaterials = priceForNylon + priceForPaint + priceForThinner + bags;
double workersPrice = (totalSumForMaterials * 0.30) * neededHours;

double finalSum = totalSumForMaterials + workersPrice;

Console.WriteLine(finalSum);