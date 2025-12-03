int[] inputData = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();

int rows = inputData[0];
int cols = inputData[1];

int[,] matrix = ReadMatrix(rows, cols);
var bestMatrixResult = FindBestSubMatrix(matrix);

int bestSumOfMatrixNums = bestMatrixResult.bestSum;
int[,] bestMatrixFound = bestMatrixResult.bestSubMatrix;

for (int i = 0; i < bestMatrixFound.GetLength(0); i++)
{
    for (int j = 0; j < bestMatrixFound.GetLength(1); j++)
    {
        Console.Write(bestMatrixFound[i, j] + " ");
    }

    Console.WriteLine();
}

Console.WriteLine(bestSumOfMatrixNums);


static (int bestSum, int[,] bestSubMatrix) FindBestSubMatrix(int[,] matrix)
{
    var bestSubMatrix = new int[2, 2];

    int bestSum = 0;

    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            int currentSum = matrix[i, j] + matrix[i + 1, j]
                + matrix[i, j + 1] + matrix[i + 1, j + 1];

            if (currentSum > bestSum)
            {
                bestSum = currentSum;

                bestSubMatrix[0, 0] = matrix[i, j];
                bestSubMatrix[0, 1] = matrix[i, j + 1];
                bestSubMatrix[1, 0] = matrix[i + 1, j];
                bestSubMatrix[1, 1] = matrix[i + 1, j + 1];
            }
        }
    }

    return (bestSum, bestSubMatrix);
}


static int[,] ReadMatrix(int rows, int cols)
{
    int[,] resultMatrix = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        int[] inputRows = Console.ReadLine()
            .Split(", ")
            .Select(int.Parse)
            .ToArray();

        for (int j = 0; j < cols; j++)
        {
            resultMatrix[i, j] = inputRows[j];
        }
    }

    return resultMatrix;
}