int matrixParameters = int.Parse(Console.ReadLine());

int rows = matrixParameters;
int cols = matrixParameters;

char[,] matrix = ReadMatrix(rows, cols);

char targetSymbol = char.Parse(Console.ReadLine());

bool isFound = false;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        char currentSymbol = matrix[i, j];

        if (currentSymbol == targetSymbol)
        {
            isFound = true;
            Console.WriteLine($"({i}, {j})");
            return;
        }
    }
}

if (!isFound)
{
    Console.WriteLine($"{targetSymbol} does not occur in the matrix");
}


static char[,] ReadMatrix(int rows, int cols)
{
    char[,] matrix = new char[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        char[] inputCharacters = Console.ReadLine().ToCharArray();

        if (inputCharacters.Length == cols)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = inputCharacters[j];
            }
        }
    }

    return matrix;
}