int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

var queue = new Queue<int>(inputNumbers);
var resultNums = new List<int>();

while (queue.Count > 0)
{
    int currentNum = queue.Dequeue();

    if (currentNum % 2 == 0)
    {
        resultNums.Add(currentNum);
    }
}

Console.WriteLine(string.Join(", ", resultNums));