int biggestNum = 0;
int secondBiggestNum = 0;
int thirdBiggestNum = 0;

int[] numbers = new int[3];

for (int i = 0; i < 3; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    numbers[i] = currentNumber;
}

Array.Sort(numbers);
Array.Reverse(numbers);

foreach (int number in numbers)
{
    Console.WriteLine(number);
}