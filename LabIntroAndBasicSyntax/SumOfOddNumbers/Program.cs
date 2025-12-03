int number = int.Parse(Console.ReadLine());

int sum = 0;
int currentNum = 1;

for (int i = 1; i <= number; i++)
{
    Console.WriteLine(currentNum);
    sum += currentNum;
    currentNum += 2;

}

Console.WriteLine($"Sum: {sum}");