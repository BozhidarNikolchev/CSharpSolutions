int fieldSize = int.Parse(Console.ReadLine());
int[] initialIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

int[] field = new int[fieldSize];

for (int i = 0; i < initialIndexes.Length; i++)
{
    int currentIndex = initialIndexes[i];

    if (currentIndex >= 0 && currentIndex <= field.Length - 1)
    {
        field[currentIndex] = 1;
    }
}

string currentCommand = string.Empty;

while ((currentCommand = Console.ReadLine()) != "end")
{
    string[] arguments = currentCommand.Split();

    int index = int.Parse(arguments[0]);
    string direction = arguments[1];
    int movement = int.Parse(arguments[2]);

    if ((index >= 0 && index <= field.Length - 1) && field[index] == 1)
    {
        field[index] = 0;
        int landingIndex;

        switch (direction)
        {
            case "right":
                landingIndex = index;
                landingIndex = index += movement;
                while ((landingIndex >= 0 && landingIndex <= field.Length - 1) && field[landingIndex] == 1)
                {
                    landingIndex += movement;
                }

                if (landingIndex >= 0 && landingIndex <= field.Length - 1)
                {
                    field[landingIndex] = 1;
                }

                break;

            case "left":
                landingIndex = index;
                landingIndex -= movement;
                while ((landingIndex >= 0 && landingIndex <= field.Length - 1) && field[landingIndex] == 1)
                {
                    landingIndex -= movement;
                }

                if (landingIndex >= 0 && landingIndex <= field.Length - 1)
                {
                    field[landingIndex] = 1;
                }

                break;
        }
    }
}

Console.WriteLine(string.Join(" ", field));