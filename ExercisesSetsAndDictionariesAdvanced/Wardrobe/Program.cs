namespace Wardrobe;

class Program
{
    static void Main(string[] args)
    {
        int linesCount = int.Parse(Console.ReadLine());

        var wardrobe = new Dictionary<string, Dictionary<string, int>>();

        for (int i = 0; i < linesCount; i++)
        {
            string[] inputData = Console.ReadLine().Split(" -> ");
            string color = inputData[0];
            string[] clothes = inputData[1].Split(",");

            if (!wardrobe.ContainsKey(color))
            {
                wardrobe[color] = new Dictionary<string, int>();
            }

            foreach (var item in clothes)
            {
                if (!wardrobe[color].ContainsKey(item))
                {
                    wardrobe[color].Add(item, 0);
                }

                wardrobe[color][item]++;
            }
        }

        string targetItem = Console.ReadLine();

        string targetColor = targetItem.Split(" ")[0];
        string targetCLothing = targetItem.Split(" ")[1];

        foreach ((string color, Dictionary<string, int> clothes) in wardrobe)
        {
            Console.WriteLine($"{color} clothes:");

            foreach ((string item, int count) in clothes)
            {
                if (color == targetColor && item == targetCLothing)
                {
                    Console.WriteLine($"* {item} - {count} (found!)");
                }
                else
                {
                    Console.WriteLine($"* {item} - {count}");
                }
            }
        }
    }
}