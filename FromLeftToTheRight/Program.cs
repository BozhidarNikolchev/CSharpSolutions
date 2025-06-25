using System;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        int numberOfLines = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfLines; i++)
        {
            BigInteger[] input = Console.ReadLine()
                                        .Split()
                                        .Select(BigInteger.Parse)
                                        .ToArray();

            BigInteger leftNumber = input[0];
            BigInteger rightNumber = input[1];

            BigInteger biggerNumber = leftNumber > rightNumber ? leftNumber : rightNumber;

            int sum = CalculateDigitSum(biggerNumber);
            Console.WriteLine(sum);
        }
    }

    static int CalculateDigitSum(BigInteger number)
    {
        return number.ToString()
                     .Where(char.IsDigit) 
                     .Select(d => d - '0') 
                     .Sum();
    }
}
