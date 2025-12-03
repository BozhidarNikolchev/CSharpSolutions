int rows = int.Parse(Console.ReadLine());

int[][] modificationArray = ReadJaggedArray(rows);

while (true)
{
    string currentCommand = Console.ReadLine();

    if (currentCommand == "END")
    {
        PrintJaggedArray(modificationArray);
        return;
    }

    PerformCommand(modificationArray, currentCommand);
}

static void PrintJaggedArray(int[][] modificationArray)
{
    for (int i = 0; i < modificationArray.Length; i++)
    {
        for (int j = 0; j < modificationArray[i].Length; j++)
        {
            Console.Write(modificationArray[i][j] + " ");
        }

        Console.WriteLine();
    }
}

static int[][] ReadJaggedArray(int rows)
{
    int[][] jaggedArray = new int[rows][];

    for (int i = 0; i < jaggedArray.Length; i++)
    {
        int[] currentArray = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        jaggedArray[i] = currentArray;

        for (int j = 0; j < currentArray.Length; j++)
        {
            jaggedArray[i][j] = currentArray[j];
        }
    }

    return jaggedArray;
}

static int[][] PerformCommand(int[][] jaggedArray, string command)
{
    string[] performCommand = command.Split();

    string action = performCommand[0];
    int row = int.Parse(performCommand[1]);
    int col = int.Parse(performCommand[2]);
    int value = int.Parse(performCommand[3]);

    bool isActionValid = action == "Add" || action == "Subtract";

    bool isIndexValid =
        row >= 0 && row < jaggedArray.Length &&
        jaggedArray[row] != null &&
        col >= 0 && col < jaggedArray[row].Length;

    if (!isActionValid || !isIndexValid)
    {
        Console.WriteLine("Invalid coordinates");
        return jaggedArray;
    }

    switch (action)
    {
        case "Add":
            jaggedArray[row][col] += value;
            break;

        case "Subtract":
            jaggedArray[row][col] -= value;
            break;
    }

    return jaggedArray;
}