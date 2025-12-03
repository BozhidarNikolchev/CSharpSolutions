double[] inputNums = Console.ReadLine().Split().Select(double.Parse).ToArray();

for (int i = 0; i < inputNums.Length; i++)
{
    int currentNum = (int)Math.Round(inputNums[i], MidpointRounding.AwayFromZero);
    Console.WriteLine($"{inputNums[i]} => {currentNum}");
}