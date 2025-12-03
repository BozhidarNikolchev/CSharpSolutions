string[] children = Console.ReadLine().Split();
int n = int.Parse(Console.ReadLine());

var queue = new Queue<string>(children);

while (queue.Count > 1)
{
    for (int i = 0; i < n - 1; i++)
    {
        var currentChild = queue.Dequeue();
        queue.Enqueue(currentChild);
    }

    Console.WriteLine($"Removed {queue.Dequeue()}");
}

Console.WriteLine($"Last is {queue.Dequeue()}");