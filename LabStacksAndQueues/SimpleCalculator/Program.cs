string[] tokens = Console.ReadLine().Split().Reverse().ToArray();

var stack = new Stack<string>(tokens);

int sum = 0;
bool isAddition = true;

while (stack.Count > 0)
{
    var currentToken = stack.Pop();

    if (currentToken == "+")
    {
        isAddition = true;
    }
    else if (currentToken == "-")
    {
        isAddition = false;
    }
    else
    {
        int number = int.Parse(currentToken);

        if (!isAddition)
        {
            number *= -1;
        }

        sum += number;
    }
}

Console.WriteLine(sum);