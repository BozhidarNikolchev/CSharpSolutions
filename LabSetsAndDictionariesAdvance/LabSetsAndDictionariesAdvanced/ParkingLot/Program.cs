var registrationPlates = new HashSet<string>();

while (true)
{
    string input = Console.ReadLine();

    if (input == "END")
    {
        break;
    }

    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("invalid command");
        continue;
    }

    string[] command = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

    string direction = command[0];
    string currentPlate = command[1];

    if (direction == "IN")
    {
        registrationPlates.Add(currentPlate);
    }
    else if (direction == "OUT")
    {
        registrationPlates.Remove(currentPlate);
    }
}

if (registrationPlates.Any())
{
    foreach (string registrationPlate in registrationPlates)
    {
        Console.WriteLine(registrationPlate);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}