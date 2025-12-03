int length = int.Parse(Console.ReadLine()); 
int width = int.Parse(Console.ReadLine()); 
int height = int.Parse(Console.ReadLine()); 
double percentage = double.Parse(Console.ReadLine()); 

int aquariumVolume = length * width *  height;
double volumeInLiters = aquariumVolume * 0.001;

double occupiedSpace = percentage / 100;

double neededLiters = volumeInLiters * (1 - occupiedSpace);

Console.WriteLine(neededLiters);