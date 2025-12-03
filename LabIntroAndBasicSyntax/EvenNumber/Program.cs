while (true)
{

    int inputNumber = int.Parse(Console.ReadLine());

    if (inputNumber % 2 != 0)
    {
        Console.WriteLine("Please write an even number.");
    }
    else
    {
        Console.WriteLine($"The number is: {Math.Abs(inputNumber)}");
        break;
    }
}