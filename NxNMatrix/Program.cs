
int inputNum = int.Parse(Console.ReadLine());

PrintNxNMatrixt(inputNum);


static void PrintNxNMatrixt(int inputNum)
{
    int filler = inputNum;

    for (int i = 0; i < filler; i++)
    {
        for (int j = 0; j < filler; j++)
        {
            Console.Write(filler + " ");
        }

        Console.WriteLine();
    }
}