int firstNum = int.Parse(Console.ReadLine());
char sign = char.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());

Console.WriteLine(CalculateAccordingToSign(firstNum, sign, secondNum));
static int CalculateAccordingToSign(int firstNum, char sign, int secondNum)
{
    int result = 0;

    if (sign == '*')
    {
        result = firstNum * secondNum;
    }
    else if (sign == '/')
    {
        result = firstNum / secondNum;
    }
    else if (sign == '+')
    {
        result = firstNum + secondNum;
    }
    else if (sign == '-')
    {
        result = firstNum - secondNum;
    }

    return result;
}