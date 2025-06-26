short counter = short.Parse(Console.ReadLine());

short balance = 0;

for (int i = 0; i < counter; i++)
{
    string inputData = Console.ReadLine();

    if (inputData == "(")
    {
        balance++;
    }
    else if (inputData == ")")
    {
        balance--;
    }

    if (balance < 0)
    {
        Console.WriteLine("UNBALANCED");
        return; 
    }
}

if (balance == 0)
{
    Console.WriteLine("BALANCED");
}
else
{
    Console.WriteLine("UNBALANCED");
}
