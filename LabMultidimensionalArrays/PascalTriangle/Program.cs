long triangleSize = int.Parse(Console.ReadLine());

if (triangleSize == 1)
{
    Console.WriteLine(1);
    return;
}

long[][] pascalTriangle = new long[triangleSize][];

pascalTriangle[0] = new long[] { 1 };
pascalTriangle[1] = new long[] { 1, 1 };

for (int i = 2; i < pascalTriangle.Length; i++)
{
    pascalTriangle[i] = new long[pascalTriangle[i - 1].Length + 1];

    pascalTriangle[i][0] = 1;
    pascalTriangle[i][pascalTriangle[i].Length - 1] = 1;

    for (int j = 1; j < pascalTriangle[i].Length - 1; j++)
    {
        pascalTriangle[i][j] = pascalTriangle[i - 1][j - 1] + pascalTriangle[i - 1][j];
    }
}

for (int i = 0; i < pascalTriangle.Length; i++)
{
    for (int j = 0; j < pascalTriangle[i].Length; j++)
    {
        Console.Write(pascalTriangle[i][j] + " ");
    }

    Console.WriteLine();
}