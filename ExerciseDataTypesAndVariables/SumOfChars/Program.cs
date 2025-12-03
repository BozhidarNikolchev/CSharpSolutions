int counter = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 0; i < counter; i++)
{
    char currentChar = char.Parse(Console.ReadLine());
    int numericValue = (int)currentChar;

    sum += numericValue;
}

Console.WriteLine($"The sum equals: {sum}");