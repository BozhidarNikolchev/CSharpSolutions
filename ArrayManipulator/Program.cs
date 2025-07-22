using System.Collections;

int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

string command = string.Empty;

while ((command = Console.ReadLine()) != "end")
{
    string[] arguments = command.Split();
    string firstArgument = arguments[0];
    string evenOrOdd;
    int count = 0;

    switch (firstArgument)
    {
        case "exchange":
            int swappingIndex = int.Parse(arguments[1]);

            if (swappingIndex >= 0 && swappingIndex < inputArray.Length)
            {
                inputArray = SwapArrayAccordingToIndex(inputArray, swappingIndex);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
            break;

        case "max":
            evenOrOdd = arguments[1];
            Console.WriteLine(MaxOddOrEvenIndex(inputArray, evenOrOdd));
            break;

        case "min":
            evenOrOdd = arguments[1];
            Console.WriteLine(MinOddOrEvenIndex(inputArray, evenOrOdd));
            break;

        case "first":
            count = int.Parse(arguments[1]);
            evenOrOdd = arguments[2];

            if (count > inputArray.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                ArrayList firstStoredList = ReturnsFirstSpecifixNumberOfElements(inputArray, count, evenOrOdd);
                Console.WriteLine("[" + string.Join(", ", firstStoredList.ToArray()) + "]");
            }
            break;

        case "last":
            count = int.Parse(arguments[1]);
            evenOrOdd = arguments[2];

            if (count > inputArray.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                ArrayList secondStoredList = ReturnsLastSpecifixNumberOfElements(inputArray, count, evenOrOdd);
                Console.WriteLine("[" + string.Join(", ", secondStoredList.ToArray()) + "]");
            }
            break;
    }
}

Console.WriteLine("[" + string.Join(", ", inputArray) + "]");

static ArrayList ReturnsLastSpecifixNumberOfElements(int[] array, int count, string command)
{
    ArrayList resultArray = new ArrayList();
    int targetOfCount = 0;

    for (int i = array.Length - 1; i >= 0; i--)
    {
        int currentNumber = array[i];

        if (CheckIfNumberIsOddOrEven(command, currentNumber))
        {
            resultArray.Add(currentNumber);
            targetOfCount++;
        }

        if (targetOfCount == count)
        {
            break;
        }
    }

    resultArray.Reverse();
    return resultArray;
}

static ArrayList ReturnsFirstSpecifixNumberOfElements(int[] array, int count, string command)
{
    ArrayList resultArray = new ArrayList();
    int targetOfCount = 0;

    for (int i = 0; i < array.Length; i++)
    {
        int currentNumber = array[i];

        if (CheckIfNumberIsOddOrEven(command, currentNumber))
        {
            resultArray.Add(currentNumber);
            targetOfCount++;
        }

        if (targetOfCount == count)
        {
            break;
        }
    }

    return resultArray;
}

static object MinOddOrEvenIndex(int[] array, string oddOrEvenCommand)
{
    int minNumber = int.MaxValue;
    int index = -1;

    for (int i = 0; i < array.Length; i++)
    {
        int currentNumber = array[i];

        if (CheckIfNumberIsOddOrEven(oddOrEvenCommand, currentNumber))
        {
            if (currentNumber <= minNumber)
            {
                minNumber = currentNumber;
                index = i;
            }
        }
    }

    if (index == -1)
    {
        return "No matches";
    }

    return $"{index}";
}

static object MaxOddOrEvenIndex(int[] array, string oddOrEvenCommand)
{
    int maxNumber = int.MinValue;
    int index = -1;

    for (int i = 0; i < array.Length; i++)
    {
        int currentNumber = array[i];

        if (CheckIfNumberIsOddOrEven(oddOrEvenCommand, currentNumber))
        {
            if (currentNumber >= maxNumber)
            {
                maxNumber = currentNumber;
                index = i;
            }
        }
    }

    if (index == -1)
    {
        return "No matches";
    }

    return index;
}

static bool CheckIfNumberIsOddOrEven(string oddOrEven, int number)
{
    if (oddOrEven == "odd" && number % 2 != 0 ||
        oddOrEven == "even" && number % 2 == 0)
    {
        return true;
    }

    return false;
}

static int[] SwapArrayAccordingToIndex(int[] array, int index)
{
    int[] changedArray = new int[array.Length];
    int currentIndex = 0;

    for (int i = index + 1; i < array.Length; i++)
    {
        changedArray[currentIndex] = array[i];
        currentIndex++;
    }

    for (int i = 0; i <= index; i++)
    {
        changedArray[currentIndex] = array[i];
        currentIndex++;
    }

    return changedArray;
}