int matrixSize = int.Parse(Console.ReadLine());

int[,] matrix = ReadMatrix(matrixSize, matrixSize);

int diagonalSum = CalcPrimaryDiagonalSumOfElements(matrix);

Console.WriteLine(diagonalSum);

static int CalcPrimaryDiagonalSumOfElements(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    int sum = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (i == j)
            {
                sum += matrix[i, j];
            }
        }
    }

    return sum;
}

static int[,] ReadMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        int[] currentRow = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = currentRow[j];
        }
    }

    return matrix;
}