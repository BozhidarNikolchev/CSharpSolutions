int rows = int.Parse(Console.ReadLine());

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < rows - i; j++)
    {
        Console.Write(" ");
    }

    int number = 1;

    for (int j = 0; j <= i; j++)
    {
        Console.Write(number + " ");
        number = number * (i - j) / (j + 1);
    }

    Console.WriteLine();
}