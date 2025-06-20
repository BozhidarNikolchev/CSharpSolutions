int counter = int.Parse(Console.ReadLine());

int[] numbers = new int[counter];

for (int i = 0; i < counter; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

Array.Reverse(numbers);
Console.Write(string.Join(" ", numbers));