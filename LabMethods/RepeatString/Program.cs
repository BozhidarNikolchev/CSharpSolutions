string inputString = Console.ReadLine();
int countOfRepeatition = Convert.ToInt32(Console.ReadLine());

RepeatString(inputString, countOfRepeatition);
static void RepeatString(string inputString, int countOfRepeatition)
{
    string resultString = string.Empty;

    for (int i = 0; i < countOfRepeatition; i++)
    {
        resultString += inputString;
    }

    Console.WriteLine(resultString);
}