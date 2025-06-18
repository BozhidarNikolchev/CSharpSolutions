int inputInteger = int.Parse(Console.ReadLine());

for (int i = 0; i < inputInteger; i++)
{
    char firstChar = (char)('a' + i);
    for (int j = 0; j < inputInteger; j++)
    {
        char secondChar = (char)('a' + j);
        for (int k = 0; k < inputInteger; k++)
        {
            char thirdChar = (char)('a' + k);
            Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
        }
    }
}