string expression = Console.ReadLine();

var stack = new Stack<int>();

for (int i = 0; i < expression.Length; i++)
{
    var symbol = expression[i];

    if (symbol == '(')
    {
        stack.Push(i);
    }

    if (symbol == ')')
    {
        var openingBracketIndex = stack.Pop();
        var closingBracketIndex = i;

        var resultExpression = expression.Substring(openingBracketIndex, closingBracketIndex - openingBracketIndex + 1);
        Console.WriteLine(resultExpression);
    }
}


