int[] matrixParameters = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();

int rows = matrixParameters[0];
int cols = matrixParameters[1];

int[,] matrix = ReadMatrix(rows, cols);

int[] sums = sumColumns(matrix);

foreach (int currentSum in sums)
{
    Console.WriteLine(currentSum);
}

static int[] sumColumns(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    int[] columnSums = new int[cols];

    for (int i = 0; i < cols; i++)
    {
        int sum = 0;

        for (int j = 0; j < rows; j++)
        {
            sum += matrix[j, i];
        }

        columnSums[i] = sum;
    }

    return columnSums;
}

static int[,] ReadMatrix(int rows, int cols)
{
    int[,] readMatrix = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        int[] input = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        for (int j = 0; j < cols; j++)
        {
            readMatrix[i, j] = input[j];
        }
    }

    return readMatrix;
}