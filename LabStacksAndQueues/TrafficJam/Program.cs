int passingVehicles = int.Parse(Console.ReadLine());

int passedCars = 0;

var queue = new Queue<string>();

while (true)
{
    string command = Console.ReadLine();

    if (command == "end")
    {
        Console.WriteLine($"{passedCars} cars passed the crossroads.");
        break;
    }
    else if (command == "green")
    {
        for (int i = 0; i < passingVehicles; i++)
        {
            if (queue.Any())
            {
                Console.WriteLine($"{queue.Dequeue()} passed!");
                passedCars++;
            }
            else
            {
                continue;
            }
        }
    }
    else
    {
        queue.Enqueue(command);
    }
}