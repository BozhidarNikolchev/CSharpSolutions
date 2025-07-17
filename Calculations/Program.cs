string command = Console.ReadLine();
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

switch (command)
{
    case "add":
        Console.WriteLine(AddNumbers(firstNumber, secondNumber));
        break;

    case "multiply":
        Console.WriteLine(MultiplyNumbers(firstNumber, secondNumber));
        break;

    case "subtract":
        Console.WriteLine(SubtractNumbers(firstNumber, secondNumber));
        break;

    case "divide":
        Console.WriteLine(DivideNumbers(firstNumber, secondNumber));
        break;
}

static int AddNumbers(int firstNumber, int secondNumber)
{
    return firstNumber + secondNumber;
}

static int MultiplyNumbers(int firstNumber, int secondNumber)
{
    return firstNumber * secondNumber;
}

static int SubtractNumbers(int firstNumber, int secondNumber)
{
    return firstNumber - secondNumber;
}

static int DivideNumbers(int firstNumber, int secondNumber)
{
    return firstNumber / secondNumber;
}