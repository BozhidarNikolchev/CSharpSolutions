int counter = int.Parse(Console.ReadLine());

double biggestVolume = 0;
string biggestKegVolume = "";

for (int i = 0; i < counter; i++)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    double height = double.Parse(Console.ReadLine());

    double volume = Math.PI * radius * radius * height;

    if (volume > biggestVolume)
    {
        biggestVolume = volume;
        biggestKegVolume = model;
    }
}

Console.WriteLine(biggestKegVolume);