string[] data = new string[3];

for (int i = 0; i < 3; i++)
{
    string currentInfo = Console.ReadLine();

    data[i] = currentInfo;
}

Console.WriteLine($"Town {data[0]} has population of {data[1]} and area {data[2]} square km.");