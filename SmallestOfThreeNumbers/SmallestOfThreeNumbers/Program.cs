int firstNum = Convert.ToInt32(Console.ReadLine());
int secondNum = Convert.ToInt32(Console.ReadLine());
int thirdNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SmallestOfThreeNums(firstNum, secondNum, thirdNum));

static int SmallestOfThreeNums(int firstNum, int secondNum, int thirdNum)
{ 
    return Math.Min(firstNum, Math.Min(secondNum, thirdNum));
}