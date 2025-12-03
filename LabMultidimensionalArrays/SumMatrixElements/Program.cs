int[] inputData = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();

int rows = inputData[0];
int cols = inputData[1];

int[,] matrix = ReadMatrix(rows, cols);

Console.WriteLine(rows);
Console.WriteLine(cols);

PrintSumOfMatrixElements(matrix);


static int[,] ReadMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        int[] currentRow = Console.ReadLine()
            .Split(", ")
            .Select(int.Parse)
            .ToArray();

        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = currentRow[j];
        }
    }

    return matrix;
}


static void PrintSumOfMatrixElements(int[,] inputMatrix)
{
    int sum = 0;

    for (int row = 0; row < inputMatrix.GetLength(0); row++)
    {
        for (int col = 0; col < inputMatrix.GetLength(1); col++)
        {
            sum += inputMatrix[row, col];
        }
    }

    Console.WriteLine(sum);
}