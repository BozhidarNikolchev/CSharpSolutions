int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());
int thirdNum = int.Parse(Console.ReadLine());

int sumResult = SumTwoIntegers(firstNum, secondNum);
int sumAfterSubtraction = SubtractSpecificInteger(sumResult, thirdNum);

Console.WriteLine(sumAfterSubtraction);
static int SubtractSpecificInteger(int minuend, int subtrahend)
{
    return minuend - subtrahend;
}

static int SumTwoIntegers(int firstNum, int secondNum)
{
    return firstNum + secondNum;
}