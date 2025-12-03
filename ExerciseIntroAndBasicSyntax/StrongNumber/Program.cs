using System;

int inputNumber = int.Parse(Console.ReadLine());
int originalNum = inputNumber;

int sum = 0;

while (inputNumber > 0)
{
    int factorial = 1;

    int lastDigit = inputNumber % 10;
    inputNumber /= 10;

    for (int i = 1; i <= lastDigit; i++)
    {
        factorial *= i;
    }

    sum += factorial;

}

if (sum == originalNum)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}


