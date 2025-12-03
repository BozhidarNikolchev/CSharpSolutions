int topOfTriangle = int.Parse(Console.ReadLine());

for (int i = 0; i < topOfTriangle; i++)
{
    PrintLine(1, i);
}

for (int i = topOfTriangle; i > 0; i--)
{
    PrintLine(1, i);
}

static void PrintLine(int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();
}