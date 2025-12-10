int countOfNumbers = int.Parse(Console.ReadLine());

var numbersByCounter = new Dictionary<int, int>();

for (int i = 0; i < countOfNumbers; i++)
{
    int inputNumber = int.Parse(Console.ReadLine());

    if (!numbersByCounter.ContainsKey(inputNumber))
    {
        numbersByCounter[inputNumber] = 0;
    }

    numbersByCounter[inputNumber]++;
}

int resultNum = numbersByCounter.Single(kvp => kvp.Value % 2 == 0).Key;

Console.WriteLine(resultNum);