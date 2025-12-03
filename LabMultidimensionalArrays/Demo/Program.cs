//int[,] matrix = new int[3, 4];

//int[,] matrix =
//{
//    new Array[] {1, 2, 3 },
//    { 4, 5, 6 }
//};

//matrix.ForEach(row => Console.WriteLine(string.Join(" ", row)));

//////////////////////////////////



//int[] input = Console.ReadLine()
//    .Split().
//    Select(int.Parse).
//    ToArray();

//int rows = input[0];
//int cols = input[1];

///////////////////////////////////////////////
//int[,] matrix = ReadMatrix();

//static int[,] ReadMatrix()
//{
//    //int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    Console.WriteLine("Rows: ");
//    int rows = int.Parse(Console.ReadLine());

//    Console.WriteLine("Cols: ");
//    int cols = int.Parse(Console.ReadLine());

//    int[,] matrix = new int[rows, cols];

//    for (int i = 0; i < rows; i++)
//    {
//        int[] matrixContent = Console.ReadLine().Split().Select(int.Parse).ToArray();

//        for (int j = 0; j < cols; j++)
//        {
//            matrix[i, j] = matrixContent[j];
//        }
//    }

//    return matrix;
//}

////////////////////////////////////////////////


///

//int rows = 3;
//int cols = 3;

//int[,] matrix = ReadMatrix(rows, cols);

//static int[,] ReadMatrix(int rows, int cols)
//{
//    int[,] resultMatrix = new int[rows, cols];

//    for (int i = 0; i < rows; i++)
//    {
//        int[] input = Console.ReadLine()
//            .Split()
//            .Select(int.Parse)
//            .ToArray();

//        for (int j = 0; j < cols; j++)
//        {
//            resultMatrix[i, j] = input[j];
//        }
//    }

//    return resultMatrix;
//}

//////////////////////////////////////


// Print by Columns

//int[,] matrix =
//{
//    { 1, 2, 3 },
//    { 4, 5, 6 },
//};

//for  (int i = 0; i < matrix.GetLength(1); i++)
//{
//    for (int j = 0; j < matrix.GetLength(0); j++)
//    {
//        Console.WriteLine(matrix[j, i]);
//    }

//    Console.WriteLine();
//}

/////////////////////////////

// Print by Rows

//int[,] matrix =
//{
//    { 1, 2, 3 },
//    { 4, 5, 6 },
//};

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        Console.WriteLine(matrix[i, j]);
//    }

//    Console.WriteLine();
//}

/////////////////////////////

//int[][] jaggedArray = new int[7][];

//jaggedArray[0] = new int[] {1};
//jaggedArray[1] = new int[] {1, 1};

//for  (int i = 2; i < jaggedArray.Length; i++)
//{
//    jaggedArray[i] = new int[jaggedArray[i - 1].Length + 1];

//    jaggedArray[i][0] = 1;
//    jaggedArray[i][jaggedArray[i].Length - 1] = 1;

//    for (int j = 1; j < jaggedArray[i].Length - 1; j++)
//    {
//        jaggedArray[i][j] = jaggedArray[i - 1][j - 1] + jaggedArray[i - 1][j]; 
//    }
//}

//for (int i = 0; i < jaggedArray.Length; i++)
//{
//    for (int j = 0; j < jaggedArray[i].Length; j++)
//    {
//        Console.Write(jaggedArray[i][j] + " ");
//    }

//    Console.WriteLine();
//}

////////////////////////////////////

