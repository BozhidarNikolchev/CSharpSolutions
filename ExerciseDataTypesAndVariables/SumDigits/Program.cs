int inputNumber = int.Parse(Console.ReadLine());
string lenghtOfnumber = inputNumber.ToString();

int sum = 0;

for (int i = 0; i < lenghtOfnumber.Length; i++)
{
    sum += inputNumber % 10;
    inputNumber /= 10;
}

Console.WriteLine(sum);