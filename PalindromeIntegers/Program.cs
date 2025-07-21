string command;

while ((command = Console.ReadLine()) != "END")
{
    int convertCommandIntoInt = int.Parse(command);
    int[] currentArray = convertCommandIntoInt.ToString().Select(d => int.Parse(d.ToString())).ToArray();

    Console.WriteLine(CheckIfNumberIsPalindrome(currentArray));
}

static bool CheckIfNumberIsPalindrome(int[] array)
{
    int[] reversedArray = array.Reverse().ToArray();

    return array.SequenceEqual(reversedArray);
}